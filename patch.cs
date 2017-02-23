
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
partial class Form1 : System.Windows.Forms.Form
{

	//Form overrides dispose to clean up the component list.
	[System.Diagnostics.DebuggerNonUserCode()]
	protected override void Dispose(bool disposing)
	{
		try {
			if (disposing && components != null) {
				components.Dispose();
			}
		} finally {
			base.Dispose(disposing);
		}
	}

	//Required by the Windows Form Designer

	private System.ComponentModel.IContainer components;
	//NOTE: The following procedure is required by the Windows Form Designer
	//It can be modified using the Windows Form Designer.  
	//Do not modify it using the code editor.
	[System.Diagnostics.DebuggerStepThrough()]
	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
		this.Label1 = new System.Windows.Forms.Label();
		this.SuspendLayout();
		//
		//Label1
		//
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(61, 39);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(188, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "*** License has been generated! ***";
		//
		//Form1
		//
		this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(309, 120);
		this.Controls.Add(this.Label1);
		this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		this.Name = "Form1";
		this.Text = "IDM Patch 6.x.x";
		this.ResumeLayout(false);
		this.PerformLayout();

	}

	internal System.Windows.Forms.Label Label1;
}

private void Form1_Load(System.Object sender, System.EventArgs e)
	{
		My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Internet Download Manager", "Email", "anymail@yourmail.com");
		My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Internet Download Manager", "Serial", "33RNZ-GWDIU-SX39F-BY2QS");
		My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Internet Download Manager", "FName", "iHack102");
		Interaction.MsgBox("*** License has been generated! ***");

	}
	public Form1()
	{
		Load += Form1_Load;
	}
}
