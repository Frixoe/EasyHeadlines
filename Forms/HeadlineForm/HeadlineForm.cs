using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Http;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;

namespace EasyHeadlines.Forms.HeadlineForm
{
    public partial class headlineForm : Form
    {
        private List<string> headlines;
        private List<string> links;
        private int hIndex;

        private HtmlAgilityPack.HtmlDocument doc;

        public headlineForm()
        {
            InitializeComponent();

            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.headlineForm_FormClosed);

            this.hIndex = 0;

            this.headlines = new List<string>();
            this.links = new List<string>();

            this.headlines.Capacity = 5;
            this.links.Capacity = 5;

            for (int i = 0; i < 5; ++i)
            {
                this.headlines.Add("Loading...");
                this.links.Add("Not Found!");
            }
            this.SetHeadline();
            this.RetrieveHeadlinesAndLinks();
        }

        private async void RetrieveHeadlinesAndLinks()
        {
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync("https://www.nytimes.com/section/world");

            this.doc = new HtmlAgilityPack.HtmlDocument();
            this.doc.LoadHtml(html);

            this.headlines = new List<string>();
            this.links = new List<string>();

            var aTags = this.doc.DocumentNode.CssSelect("a.story-link");
            for (int i = 0; i < 5; ++i) this.links.Add(aTags.ElementAt(i).GetAttributeValue("href", ""));

            var headlineTags = aTags.CssSelect("h2.headline");
            for (int i = 0; i < 5; ++i) this.headlines.Add(headlineTags.ElementAt(i).InnerText.Trim());
            
            this.SetHeadline();
        }

        private void SetHeadline()
        {
            this.headlineLabel.Text = this.headlines[this.hIndex];
        }

        private void headlineForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void leftArrow_Click(object sender, EventArgs e)
        {
            if (this.hIndex == 0) this.hIndex = this.headlines.Count - 1;
            else this.hIndex--;

            this.SetHeadline();
        }

        private void rightArrow_Click(object sender, EventArgs e)
        {
            if (this.hIndex == this.headlines.Count - 1) this.hIndex = 0;
            else this.hIndex++;

            this.SetHeadline();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewStoryButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.links[this.hIndex]);
        }
    }
}
