using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ClassLink.OAuth2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            var value = new DataGridViewTextBoxColumn
            {
                Name = "Value"
            };
            var property = new DataGridViewTextBoxColumn
            {
                Name = "Property"
            };

            value.SortMode = DataGridViewColumnSortMode.NotSortable;
            property.SortMode = DataGridViewColumnSortMode.NotSortable;

            infoGridView.Columns.AddRange(property, value);
            infoGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            infoGridView.BackgroundColor = Color.White;
            infoGridView.RowHeadersVisible = false;

            endpointBox.Text = @"http://nodeapi.classlink.com/v2/my/info";
        }

        private void getCode_Click(object sender, EventArgs e)
        {
            if (redirectUri.Text == string.Empty)
            {
                MessageBox.Show(@"Enter Redirect URI");
                return;
            }

            if (clientId.Text == string.Empty)
            {
                MessageBox.Show(@"Enter Client ID");
                return;
            }

            getCode.Enabled = false;
            codeWorker.RunWorkerAsync();
        }

        private void codeWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var url =
                $@"https://launchpad.classlink.com/oauth2/v2/auth?scope=profile&redirect_uri={redirectUri.Text}&client_id={clientId.Text}&response_type=code";
            System.Diagnostics.Process.Start(url);
        }

        private void codeWorker_RunComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            getCode.Enabled = true;
        }

        private void getToken_Click(object sender, EventArgs e)
        {
            if (clientSecret.Text == string.Empty)
            {
                MessageBox.Show(@"Enter Client Secret");
                return;
            }

            if (clientId.Text == string.Empty)
            {
                MessageBox.Show(@"Enter Client ID");
                return;
            }

            if (code.Text == string.Empty)
            {
                MessageBox.Show(@"Enter Code");
                return;
            }

            getToken.Enabled = false;
            tokenWorker.RunWorkerAsync();
        }

        private void tokenWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            const string url = "https://launchpad.classlink.com/oauth2/v2/token";
            var formContent = new FormUrlEncodedContent(new []
            {
                new KeyValuePair<string, string>("code", code.Text),
                new KeyValuePair<string, string>("client_id", clientId.Text),
                new KeyValuePair<string, string>("client_secret", clientSecret.Text)   
            });

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded");
                var postTask = client.PostAsync(url, formContent);
                postTask.Wait();
                var stringTask = postTask.Result.Content.ReadAsStringAsync();
                stringTask.Wait();
                var token = JsonConvert.DeserializeObject<Token>(stringTask.Result);
                Invoke(new Action(() =>
                {
                    tokenBox.Text = token.access_token;
                }));
            }
        }

        private void tokenWorker_RunComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            getToken.Enabled = true;
        }

        private void getTest_Click(object sender, EventArgs e)
        {
            if (tokenBox.Text == string.Empty)
            {
                MessageBox.Show(@"Get Token first");
                return;
            }
            getTest.Enabled = false;
            userWorker.RunWorkerAsync();
        }

        private void userWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var url = endpointBox.Text;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", tokenBox.Text);
                var postTask = client.GetAsync(url);
                postTask.Wait();
                var stringTask = postTask.Result.Content.ReadAsStringAsync();
                stringTask.Wait();
                var info = JsonConvert.DeserializeObject<info>(stringTask.Result);
                var infoDict = info.toDictionary();
                Invoke(new Action(() =>
                {
                    populate(infoDict);
                }));
            }
        }

        private void userWorker_RunComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            getTest.Enabled = true;

        }

        private void populate(IDictionary<string, object> input)
        {
            infoGridView.Rows.Clear();
            infoGridView.Rows.AddRange(input.Select(kvp =>
            {
                var row = new DataGridViewRow();
                row.CreateCells(infoGridView, kvp.Key, kvp.Value);
                row.ReadOnly = true;
                return row;
            }).ToArray());   
        }
    }
}
