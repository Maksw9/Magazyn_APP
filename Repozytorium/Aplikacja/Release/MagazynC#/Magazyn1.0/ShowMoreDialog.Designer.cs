namespace Magazyn1._0
{
    partial class ShowMoreDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.magazynDataSet = new Magazyn1._0.MagazynDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Magazyn1._0.MagazynDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Magazyn1._0.MagazynDataSetTableAdapters.TableAdapterManager();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.text = new MetroFramework.Controls.MetroLabel();
            this.idTextBox = new MetroFramework.Controls.MetroTextBox();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.producerTextBox = new MetroFramework.Controls.MetroTextBox();
            this.aleyTextBox = new MetroFramework.Controls.MetroTextBox();
            this.boxTextBox = new MetroFramework.Controls.MetroTextBox();
            this.positionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.amountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.typeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.modelTextBox = new MetroFramework.Controls.MetroTextBox();
            this.sizeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.changeBtn = new MetroFramework.Controls.MetroTile();
            this.saveBtn = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // magazynDataSet
            // 
            this.magazynDataSet.DataSetName = "MagazynDataSet";
            this.magazynDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.magazynDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Magazyn1._0.MagazynDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(62, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(27, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Id: ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(34, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nazwa: ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 121);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Producent: ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(44, 150);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Aleja: ";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(30, 208);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(59, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Pozycja: ";
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(44, 179);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(38, 19);
            this.text.TabIndex = 4;
            this.text.Text = "Box: ";
            // 
            // idTextBox
            // 
            // 
            // 
            // 
            this.idTextBox.CustomButton.Image = null;
            this.idTextBox.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.idTextBox.CustomButton.Name = "";
            this.idTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.idTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idTextBox.CustomButton.TabIndex = 1;
            this.idTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idTextBox.CustomButton.UseSelectable = true;
            this.idTextBox.CustomButton.Visible = false;
            this.idTextBox.Enabled = false;
            this.idTextBox.Lines = new string[0];
            this.idTextBox.Location = new System.Drawing.Point(95, 63);
            this.idTextBox.MaxLength = 32767;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.PasswordChar = '\0';
            this.idTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idTextBox.SelectedText = "";
            this.idTextBox.SelectionLength = 0;
            this.idTextBox.SelectionStart = 0;
            this.idTextBox.ShortcutsEnabled = true;
            this.idTextBox.Size = new System.Drawing.Size(227, 23);
            this.idTextBox.TabIndex = 6;
            this.idTextBox.UseSelectable = true;
            this.idTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nameTextBox
            // 
            // 
            // 
            // 
            this.nameTextBox.CustomButton.Image = null;
            this.nameTextBox.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.nameTextBox.CustomButton.Name = "";
            this.nameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTextBox.CustomButton.TabIndex = 1;
            this.nameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTextBox.CustomButton.UseSelectable = true;
            this.nameTextBox.CustomButton.Visible = false;
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Lines = new string[0];
            this.nameTextBox.Location = new System.Drawing.Point(95, 92);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.SelectionLength = 0;
            this.nameTextBox.SelectionStart = 0;
            this.nameTextBox.ShortcutsEnabled = true;
            this.nameTextBox.Size = new System.Drawing.Size(227, 23);
            this.nameTextBox.TabIndex = 7;
            this.nameTextBox.UseSelectable = true;
            this.nameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // producerTextBox
            // 
            // 
            // 
            // 
            this.producerTextBox.CustomButton.Image = null;
            this.producerTextBox.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.producerTextBox.CustomButton.Name = "";
            this.producerTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.producerTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.producerTextBox.CustomButton.TabIndex = 1;
            this.producerTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.producerTextBox.CustomButton.UseSelectable = true;
            this.producerTextBox.CustomButton.Visible = false;
            this.producerTextBox.Enabled = false;
            this.producerTextBox.Lines = new string[0];
            this.producerTextBox.Location = new System.Drawing.Point(95, 121);
            this.producerTextBox.MaxLength = 32767;
            this.producerTextBox.Name = "producerTextBox";
            this.producerTextBox.PasswordChar = '\0';
            this.producerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.producerTextBox.SelectedText = "";
            this.producerTextBox.SelectionLength = 0;
            this.producerTextBox.SelectionStart = 0;
            this.producerTextBox.ShortcutsEnabled = true;
            this.producerTextBox.Size = new System.Drawing.Size(227, 23);
            this.producerTextBox.TabIndex = 8;
            this.producerTextBox.UseSelectable = true;
            this.producerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.producerTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // aleyTextBox
            // 
            // 
            // 
            // 
            this.aleyTextBox.CustomButton.Image = null;
            this.aleyTextBox.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.aleyTextBox.CustomButton.Name = "";
            this.aleyTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.aleyTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.aleyTextBox.CustomButton.TabIndex = 1;
            this.aleyTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.aleyTextBox.CustomButton.UseSelectable = true;
            this.aleyTextBox.CustomButton.Visible = false;
            this.aleyTextBox.Enabled = false;
            this.aleyTextBox.Lines = new string[0];
            this.aleyTextBox.Location = new System.Drawing.Point(95, 150);
            this.aleyTextBox.MaxLength = 32767;
            this.aleyTextBox.Name = "aleyTextBox";
            this.aleyTextBox.PasswordChar = '\0';
            this.aleyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aleyTextBox.SelectedText = "";
            this.aleyTextBox.SelectionLength = 0;
            this.aleyTextBox.SelectionStart = 0;
            this.aleyTextBox.ShortcutsEnabled = true;
            this.aleyTextBox.Size = new System.Drawing.Size(227, 23);
            this.aleyTextBox.TabIndex = 9;
            this.aleyTextBox.UseSelectable = true;
            this.aleyTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.aleyTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // boxTextBox
            // 
            // 
            // 
            // 
            this.boxTextBox.CustomButton.Image = null;
            this.boxTextBox.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.boxTextBox.CustomButton.Name = "";
            this.boxTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.boxTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.boxTextBox.CustomButton.TabIndex = 1;
            this.boxTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.boxTextBox.CustomButton.UseSelectable = true;
            this.boxTextBox.CustomButton.Visible = false;
            this.boxTextBox.Enabled = false;
            this.boxTextBox.Lines = new string[0];
            this.boxTextBox.Location = new System.Drawing.Point(95, 179);
            this.boxTextBox.MaxLength = 32767;
            this.boxTextBox.Name = "boxTextBox";
            this.boxTextBox.PasswordChar = '\0';
            this.boxTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.boxTextBox.SelectedText = "";
            this.boxTextBox.SelectionLength = 0;
            this.boxTextBox.SelectionStart = 0;
            this.boxTextBox.ShortcutsEnabled = true;
            this.boxTextBox.Size = new System.Drawing.Size(227, 23);
            this.boxTextBox.TabIndex = 12;
            this.boxTextBox.UseSelectable = true;
            this.boxTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.boxTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // positionTextBox
            // 
            // 
            // 
            // 
            this.positionTextBox.CustomButton.Image = null;
            this.positionTextBox.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.positionTextBox.CustomButton.Name = "";
            this.positionTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.positionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.positionTextBox.CustomButton.TabIndex = 1;
            this.positionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.positionTextBox.CustomButton.UseSelectable = true;
            this.positionTextBox.CustomButton.Visible = false;
            this.positionTextBox.Enabled = false;
            this.positionTextBox.Lines = new string[0];
            this.positionTextBox.Location = new System.Drawing.Point(95, 208);
            this.positionTextBox.MaxLength = 32767;
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.PasswordChar = '\0';
            this.positionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.positionTextBox.SelectedText = "";
            this.positionTextBox.SelectionLength = 0;
            this.positionTextBox.SelectionStart = 0;
            this.positionTextBox.ShortcutsEnabled = true;
            this.positionTextBox.Size = new System.Drawing.Size(227, 23);
            this.positionTextBox.TabIndex = 11;
            this.positionTextBox.UseSelectable = true;
            this.positionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.positionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // amountTextBox
            // 
            // 
            // 
            // 
            this.amountTextBox.CustomButton.Image = null;
            this.amountTextBox.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.amountTextBox.CustomButton.Name = "";
            this.amountTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.amountTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.amountTextBox.CustomButton.TabIndex = 1;
            this.amountTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.amountTextBox.CustomButton.UseSelectable = true;
            this.amountTextBox.CustomButton.Visible = false;
            this.amountTextBox.Enabled = false;
            this.amountTextBox.Lines = new string[0];
            this.amountTextBox.Location = new System.Drawing.Point(95, 237);
            this.amountTextBox.MaxLength = 32767;
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.PasswordChar = '\0';
            this.amountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amountTextBox.SelectedText = "";
            this.amountTextBox.SelectionLength = 0;
            this.amountTextBox.SelectionStart = 0;
            this.amountTextBox.ShortcutsEnabled = true;
            this.amountTextBox.Size = new System.Drawing.Size(227, 23);
            this.amountTextBox.TabIndex = 13;
            this.amountTextBox.UseSelectable = true;
            this.amountTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amountTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(45, 237);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(37, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Ilość:";
            // 
            // typeTextBox
            // 
            // 
            // 
            // 
            this.typeTextBox.CustomButton.Image = null;
            this.typeTextBox.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.typeTextBox.CustomButton.Name = "";
            this.typeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.typeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.typeTextBox.CustomButton.TabIndex = 1;
            this.typeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.typeTextBox.CustomButton.UseSelectable = true;
            this.typeTextBox.CustomButton.Visible = false;
            this.typeTextBox.Enabled = false;
            this.typeTextBox.Lines = new string[0];
            this.typeTextBox.Location = new System.Drawing.Point(95, 266);
            this.typeTextBox.MaxLength = 32767;
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.PasswordChar = '\0';
            this.typeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.typeTextBox.SelectedText = "";
            this.typeTextBox.SelectionLength = 0;
            this.typeTextBox.SelectionStart = 0;
            this.typeTextBox.ShortcutsEnabled = true;
            this.typeTextBox.Size = new System.Drawing.Size(227, 23);
            this.typeTextBox.TabIndex = 15;
            this.typeTextBox.UseSelectable = true;
            this.typeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.typeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // modelTextBox
            // 
            // 
            // 
            // 
            this.modelTextBox.CustomButton.Image = null;
            this.modelTextBox.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.modelTextBox.CustomButton.Name = "";
            this.modelTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.modelTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.modelTextBox.CustomButton.TabIndex = 1;
            this.modelTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.modelTextBox.CustomButton.UseSelectable = true;
            this.modelTextBox.CustomButton.Visible = false;
            this.modelTextBox.Enabled = false;
            this.modelTextBox.Lines = new string[0];
            this.modelTextBox.Location = new System.Drawing.Point(95, 295);
            this.modelTextBox.MaxLength = 32767;
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.PasswordChar = '\0';
            this.modelTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.modelTextBox.SelectedText = "";
            this.modelTextBox.SelectionLength = 0;
            this.modelTextBox.SelectionStart = 0;
            this.modelTextBox.ShortcutsEnabled = true;
            this.modelTextBox.Size = new System.Drawing.Size(227, 23);
            this.modelTextBox.TabIndex = 16;
            this.modelTextBox.UseSelectable = true;
            this.modelTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.modelTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // sizeTextBox
            // 
            // 
            // 
            // 
            this.sizeTextBox.CustomButton.Image = null;
            this.sizeTextBox.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.sizeTextBox.CustomButton.Name = "";
            this.sizeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.sizeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sizeTextBox.CustomButton.TabIndex = 1;
            this.sizeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sizeTextBox.CustomButton.UseSelectable = true;
            this.sizeTextBox.CustomButton.Visible = false;
            this.sizeTextBox.Enabled = false;
            this.sizeTextBox.Lines = new string[0];
            this.sizeTextBox.Location = new System.Drawing.Point(95, 324);
            this.sizeTextBox.MaxLength = 32767;
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.PasswordChar = '\0';
            this.sizeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sizeTextBox.SelectedText = "";
            this.sizeTextBox.SelectionLength = 0;
            this.sizeTextBox.SelectionStart = 0;
            this.sizeTextBox.ShortcutsEnabled = true;
            this.sizeTextBox.Size = new System.Drawing.Size(227, 23);
            this.sizeTextBox.TabIndex = 17;
            this.sizeTextBox.UseSelectable = true;
            this.sizeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sizeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(52, 266);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(32, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Typ:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(34, 295);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(50, 19);
            this.metroLabel8.TabIndex = 19;
            this.metroLabel8.Text = "Model:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(20, 324);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(62, 19);
            this.metroLabel9.TabIndex = 20;
            this.metroLabel9.Text = "Rozmiar:";
            // 
            // changeBtn
            // 
            this.changeBtn.ActiveControl = null;
            this.changeBtn.Location = new System.Drawing.Point(338, 63);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(75, 81);
            this.changeBtn.TabIndex = 21;
            this.changeBtn.Text = "Edytuj";
            this.changeBtn.UseSelectable = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.ActiveControl = null;
            this.saveBtn.Location = new System.Drawing.Point(338, 149);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 81);
            this.saveBtn.TabIndex = 22;
            this.saveBtn.Text = "Zapisz";
            this.saveBtn.UseSelectable = true;
            // 
            // ShowMoreDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 390);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.boxTextBox);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.aleyTextBox);
            this.Controls.Add(this.producerTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.text);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ShowMoreDialog";
            this.Text = "Informacje o produkcie";
            this.Load += new System.EventHandler(this.ShowMoreDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magazynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MagazynDataSet magazynDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private MagazynDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private MagazynDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel text;
        private MetroFramework.Controls.MetroTextBox idTextBox;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
        private MetroFramework.Controls.MetroTextBox producerTextBox;
        private MetroFramework.Controls.MetroTextBox aleyTextBox;
        private MetroFramework.Controls.MetroTextBox boxTextBox;
        private MetroFramework.Controls.MetroTextBox positionTextBox;
        private MetroFramework.Controls.MetroTextBox amountTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox typeTextBox;
        private MetroFramework.Controls.MetroTextBox modelTextBox;
        private MetroFramework.Controls.MetroTextBox sizeTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTile changeBtn;
        private MetroFramework.Controls.MetroTile saveBtn;
    }
}