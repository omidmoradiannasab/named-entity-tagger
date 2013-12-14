﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NER_SPLRL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //persianLocationTaggerButton_click
        private void button1_Click(object sender, EventArgs e)
        {
            PersianLocationTagger plt = new PersianLocationTagger();
            plt.LoadCorpus(@"C:\Users\Omid\Desktop\file(9).txt");
            plt.TagCorpus();
            plt.SaveCorpus(@"C:\Users\Omid\Desktop\file(9)-lt.txt");
        }

        private void SlovakLocationTaggerButton_Click(object sender, EventArgs e)
        {
            SlovakLocationTagger plt = new SlovakLocationTagger();
            plt.LoadCorpus(@"C:\Users\Omid\Desktop\slovak-text.txt");
            plt.TagCorpus();
            plt.SaveCorpus(@"C:\Users\Omid\Desktop\slovak-text-tagged.txt");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersianPersonTagger plt = new PersianPersonTagger();
            plt.LoadCorpus(@"C:\Users\Omid\Desktop\file(9).txt");
            plt.TagCorpus();
            plt.SaveCorpus(@"C:\Users\Omid\Desktop\file(9)-pt.txt");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SlovakPersonTagger plt = new SlovakPersonTagger();
            plt.LoadCorpus(@"C:\Users\Omid\Desktop\slovak-text.txt");
            plt.TagCorpus();
            plt.SaveCorpus(@"C:\Users\Omid\Desktop\slovak-text-ptagged.txt");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersianTimeTagger ptt = new PersianTimeTagger();
            ptt.LoadCorpus(@"C:\Users\Omid\Desktop\file(9).txt");
            ptt.TagCorpus();
            ptt.SaveCorpus(@"C:\Users\Omid\Desktop\file(9)-tt.txt");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //todo
        }
    }
}
