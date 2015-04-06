﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Nut.Models;

namespace Nut.Demo {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
            cmbLang.DataSource = new List<string>() { "en", "es", "fr", "ru", "tr" };
            cmbCurrency.DataSource = new List<string>() { "usd", "eur", "rub", "try" };
        }

        private void btnMoneyToText_Click(object sender, EventArgs e) {
            var lang = cmbLang.SelectedValue.ToString();
            var currency = cmbCurrency.SelectedValue.ToString();
            var options = new Options {
                MainUnitNotConvertedToText = cbMainUnitNotConvertedToText.Checked,
                SubUnitNotConvertedToText = cbSubUnitNotConvertToText.Checked,
                MainUnitFirstCharUpper = cbMainUnitFirstCharUpper.Checked,
                SubUnitFirstCharUpper = cbSubUnitFirstCharUpper.Checked,
                CurrencyFirstCharUpper = cbCurrencyFirstCharUpper.Checked,
                SubUnitZeroNotDisplayed = cbSubUnitZeroNotIncluded.Checked,
            };
            var text = Convert.ToDecimal(txtNumber.Text).ToText(currency, lang, options);
            txtResultText.Text = text;
        }
    }
}
