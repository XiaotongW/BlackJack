﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
	public partial class PartieForm : Form
	{
		Partie partie;
		public PartieForm(Partie partie)
		{
			this.partie = partie;
			InitializeComponent();
		}
	}
}
