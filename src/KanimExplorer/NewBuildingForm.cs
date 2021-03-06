﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KanimalExplorer
{
	public partial class NewBuildingForm : Form
	{
		public string BuildingName
		{ get; private set; }

		public int BuildingWidth
		{ get; private set; }

		public int BuildingHeight
		{ get; private set; }

		public NewBuildingForm()
		{
			InitializeComponent();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			BuildingName = textBox1.Text;
			BuildingWidth = (int)numericUpDown1.Value;
			BuildingHeight = (int)numericUpDown2.Value;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
