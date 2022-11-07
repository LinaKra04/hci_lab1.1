
namespace hci_lab1._1
{
    partial class lab1_1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lab1_1));
            this.showMssg = new System.Windows.Forms.Button();
            this.defMssg1 = new System.Windows.Forms.Button();
            this.defMssg2 = new System.Windows.Forms.Button();
            this.progr = new System.Windows.Forms.Label();
            this.execution = new System.Windows.Forms.Button();
            this.showMssgActs = new System.Windows.Forms.CheckBox();
            this.showProgActs = new System.Windows.Forms.CheckBox();
            this.enableMssgActs = new System.Windows.Forms.CheckBox();
            this.enableProgActs = new System.Windows.Forms.CheckBox();
            this.exit_ = new System.Windows.Forms.Button();
            this.enterMssg = new System.Windows.Forms.Label();
            this.programActsList = new System.Windows.Forms.ComboBox();
            this.mssgBox = new System.Windows.Forms.TextBox();
            this.actionsShow = new System.Windows.Forms.GroupBox();
            this.actionsEnable = new System.Windows.Forms.GroupBox();
            this.focusCtrl = new System.Windows.Forms.Button();
            this.actionsShow.SuspendLayout();
            this.actionsEnable.SuspendLayout();
            this.SuspendLayout();
            // 
            // showMssg
            // 
            this.showMssg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.showMssg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.showMssg, "showMssg");
            this.showMssg.Name = "showMssg";
            this.showMssg.UseVisualStyleBackColor = false;
            this.showMssg.Click += new System.EventHandler(this.Form1_Load);
            this.showMssg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.showMssg_KeyDown);
            // 
            // defMssg1
            // 
            this.defMssg1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.defMssg1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.defMssg1, "defMssg1");
            this.defMssg1.Name = "defMssg1";
            this.defMssg1.UseVisualStyleBackColor = false;
            this.defMssg1.Click += new System.EventHandler(this.defMssg1_Click);
            this.defMssg1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.defMssg1_KeyDown);
            // 
            // defMssg2
            // 
            this.defMssg2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.defMssg2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.defMssg2, "defMssg2");
            this.defMssg2.Name = "defMssg2";
            this.defMssg2.UseVisualStyleBackColor = false;
            this.defMssg2.Click += new System.EventHandler(this.defMssg2_Click);
            this.defMssg2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.defMssg2_KeyDown);
            // 
            // progr
            // 
            resources.ApplyResources(this.progr, "progr");
            this.progr.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progr.Name = "progr";
            this.progr.Click += new System.EventHandler(this.label1_Click);
            // 
            // execution
            // 
            this.execution.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.execution.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.execution, "execution");
            this.execution.Name = "execution";
            this.execution.UseVisualStyleBackColor = false;
            this.execution.Click += new System.EventHandler(this.execution_Click);
            this.execution.KeyDown += new System.Windows.Forms.KeyEventHandler(this.execution_KeyDown);
            // 
            // showMssgActs
            // 
            resources.ApplyResources(this.showMssgActs, "showMssgActs");
            this.showMssgActs.Checked = true;
            this.showMssgActs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showMssgActs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showMssgActs.Name = "showMssgActs";
            this.showMssgActs.UseVisualStyleBackColor = true;
            this.showMssgActs.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.showMssgActs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.showMssgActs_KeyDown);
            // 
            // showProgActs
            // 
            resources.ApplyResources(this.showProgActs, "showProgActs");
            this.showProgActs.Checked = true;
            this.showProgActs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showProgActs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showProgActs.Name = "showProgActs";
            this.showProgActs.UseVisualStyleBackColor = true;
            this.showProgActs.CheckedChanged += new System.EventHandler(this.showProgActs_CheckedChanged);
            this.showProgActs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.showProgActs_KeyDown);
            // 
            // enableMssgActs
            // 
            resources.ApplyResources(this.enableMssgActs, "enableMssgActs");
            this.enableMssgActs.Checked = true;
            this.enableMssgActs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableMssgActs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enableMssgActs.Name = "enableMssgActs";
            this.enableMssgActs.UseVisualStyleBackColor = true;
            this.enableMssgActs.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            this.enableMssgActs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enableMssgActs_KeyDown);
            // 
            // enableProgActs
            // 
            resources.ApplyResources(this.enableProgActs, "enableProgActs");
            this.enableProgActs.Checked = true;
            this.enableProgActs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableProgActs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enableProgActs.Name = "enableProgActs";
            this.enableProgActs.UseVisualStyleBackColor = true;
            this.enableProgActs.CheckedChanged += new System.EventHandler(this.enableProgActs_CheckedChanged);
            this.enableProgActs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enableProgActs_KeyDown);
            // 
            // exit_
            // 
            this.exit_.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit_.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.exit_, "exit_");
            this.exit_.Name = "exit_";
            this.exit_.UseVisualStyleBackColor = false;
            this.exit_.Click += new System.EventHandler(this.exit__Click);
            this.exit_.KeyDown += new System.Windows.Forms.KeyEventHandler(this.exit__KeyDown);
            // 
            // enterMssg
            // 
            resources.ApplyResources(this.enterMssg, "enterMssg");
            this.enterMssg.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.enterMssg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enterMssg.Name = "enterMssg";
            this.enterMssg.Click += new System.EventHandler(this.enterMssg_Click);
            // 
            // programActsList
            // 
            this.programActsList.FormattingEnabled = true;
            this.programActsList.Items.AddRange(new object[] {
            resources.GetString("programActsList.Items"),
            resources.GetString("programActsList.Items1"),
            resources.GetString("programActsList.Items2")});
            resources.ApplyResources(this.programActsList, "programActsList");
            this.programActsList.Name = "programActsList";
            this.programActsList.SelectedIndexChanged += new System.EventHandler(this.programActsList_SelectedIndexChanged);
            this.programActsList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.programActsList_KeyDown);
            // 
            // mssgBox
            // 
            this.mssgBox.AcceptsTab = true;
            resources.ApplyResources(this.mssgBox, "mssgBox");
            this.mssgBox.Name = "mssgBox";
            this.mssgBox.TextChanged += new System.EventHandler(this.mssgBox_TextChanged);
            this.mssgBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mssgBox_KeyDown);
            // 
            // actionsShow
            // 
            this.actionsShow.Controls.Add(this.showMssgActs);
            this.actionsShow.Controls.Add(this.showProgActs);
            resources.ApplyResources(this.actionsShow, "actionsShow");
            this.actionsShow.Name = "actionsShow";
            this.actionsShow.TabStop = false;
            this.actionsShow.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // actionsEnable
            // 
            this.actionsEnable.Controls.Add(this.enableMssgActs);
            this.actionsEnable.Controls.Add(this.enableProgActs);
            resources.ApplyResources(this.actionsEnable, "actionsEnable");
            this.actionsEnable.Name = "actionsEnable";
            this.actionsEnable.TabStop = false;
            this.actionsEnable.Enter += new System.EventHandler(this.actionsEnable_Enter);
            // 
            // focusCtrl
            // 
            this.focusCtrl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.focusCtrl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.focusCtrl, "focusCtrl");
            this.focusCtrl.Name = "focusCtrl";
            this.focusCtrl.UseVisualStyleBackColor = false;
            this.focusCtrl.Click += new System.EventHandler(this.focusCtrl_Click);
            // 
            // lab1_1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.focusCtrl);
            this.Controls.Add(this.actionsEnable);
            this.Controls.Add(this.actionsShow);
            this.Controls.Add(this.programActsList);
            this.Controls.Add(this.enterMssg);
            this.Controls.Add(this.exit_);
            this.Controls.Add(this.execution);
            this.Controls.Add(this.mssgBox);
            this.Controls.Add(this.progr);
            this.Controls.Add(this.defMssg2);
            this.Controls.Add(this.defMssg1);
            this.Controls.Add(this.showMssg);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "lab1_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.actionsShow.ResumeLayout(false);
            this.actionsShow.PerformLayout();
            this.actionsEnable.ResumeLayout(false);
            this.actionsEnable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showMssg;
        private System.Windows.Forms.Button defMssg1;
        private System.Windows.Forms.Button defMssg2;
        private System.Windows.Forms.Label progr;
        private System.Windows.Forms.Button execution;
        private System.Windows.Forms.CheckBox showMssgActs;
        private System.Windows.Forms.CheckBox showProgActs;
        private System.Windows.Forms.CheckBox enableMssgActs;
        private System.Windows.Forms.CheckBox enableProgActs;
        private System.Windows.Forms.Button exit_;
        private System.Windows.Forms.Label enterMssg;
        private System.Windows.Forms.ComboBox programActsList;
        private System.Windows.Forms.TextBox mssgBox;
        private System.Windows.Forms.GroupBox actionsShow;
        private System.Windows.Forms.GroupBox actionsEnable;
        private System.Windows.Forms.Button focusCtrl;
    }
}

