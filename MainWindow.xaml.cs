﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LengthCalculator_2
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        // 全域變數
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAllClear_Click(object sender, RoutedEventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtCM.Text; // 將txtCM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtM.Text = string.Format("{0:0.##########}", douOutput / 100);
                txtKM.Text = string.Format("{0:0.##########}", douOutput / 100000);
                txtIn.Text = string.Format("{0:0.##########}", douOutput / 2.54);
                txtFt.Text = string.Format("{0:0.##########}", douOutput / 30.48);
                txtYard.Text = string.Format("{0:0.##########}", douOutput / 91.44);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtM.Text; // 將txtM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douOutput * 100);
                txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.001);
                txtIn.Text = string.Format("{0:0.##########}", douOutput * 39.37);
                txtFt.Text = string.Format("{0:0.##########}", douOutput * 3.28084);
                txtYard.Text = string.Format("{0:0.##########}", douOutput * 1.09361);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtM文字框清除
                txtInfo.Text = "請輸入數字";
                txtM.Text = "";
            }

        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtKM.Text; // 將txtM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douOutput * 100000);
                txtM.Text = string.Format("{0:0.##########}", douOutput * 1000);
                txtIn.Text = string.Format("{0:0.##########}", douOutput * 39370);
                txtFt.Text = string.Format("{0:0.##########}", douOutput * 3280.84);
                txtYard.Text = string.Format("{0:0.##########}", douOutput * 1093.6);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtKM文字框清除
                txtInfo.Text = "請輸入數字";
                txtKM.Text = "";
            }

        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtIn.Text; // 將txtIn文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douOutput * 2.54);
                txtM.Text = string.Format("{0:0.##########}", douOutput * 0.0254);
                txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.00003);
                txtFt.Text = string.Format("{0:0.##########}", douOutput * 0.08333);
                txtYard.Text = string.Format("{0:0.##########}", douOutput * 0.02778);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtIn文字框清除
                txtInfo.Text = "請輸入數字";
                txtIn.Text = "";
            }

        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtFt.Text; // 將txtFt文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douOutput * 30.4801);
                txtM.Text = string.Format("{0:0.##########}", douOutput * 0.3048);
                txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.00031);
                txtIn.Text = string.Format("{0:0.##########}", douOutput * 12);
                txtYard.Text = string.Format("{0:0.##########}", douOutput * 0.33333);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtFt文字框清除
                txtInfo.Text = "請輸入數字";
                txtFt.Text = "";
            }

        }

        private void txtYard_TextChanged(object sender, TextChangedEventArgs e)
        {
            strInput = txtYard.Text; // 將txtYard文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douOutput * 91.4402);
                txtM.Text = string.Format("{0:0.##########}", douOutput * 0.9144);
                txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.00091);
                txtIn.Text = string.Format("{0:0.##########}", douOutput * 36);
                txtFt.Text = string.Format("{0:0.##########}", douOutput * 3);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtYard文字框清除
                txtInfo.Text = "請輸入數字";
                txtYard.Text = "";
            }

        }
    }
}
