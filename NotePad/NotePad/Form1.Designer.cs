namespace NotePad
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontSize = new System.Windows.Forms.ToolStripComboBox();
            this.TextTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextType = new System.Windows.Forms.ToolStripComboBox();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.regularToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.highlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripWordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.textToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.saveAsToolStripMenuItem.Text = "S&ave As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.fontSizeToolStripMenuItem,
            this.TextTypeToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "C&ut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // fontSizeToolStripMenuItem
            // 
            this.fontSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontSize});
            this.fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            this.fontSizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontSizeToolStripMenuItem.Text = "Font Size";
            // 
            // FontSize
            // 
            this.FontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(121, 21);
            this.FontSize.SelectedIndexChanged += new System.EventHandler(this.FontSize_SelectedIndexChanged);
            // 
            // TextTypeToolStripMenuItem
            // 
            this.TextTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextType});
            this.TextTypeToolStripMenuItem.Name = "TextTypeToolStripMenuItem";
            this.TextTypeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.TextTypeToolStripMenuItem.Text = "Text Type";
            // 
            // TextType
            // 
            this.TextType.AutoCompleteCustomSource.AddRange(new string[] {
            "Arial"});
            this.TextType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextType.Items.AddRange(new object[] {
            "Arial",
            "Abadi MT Condensed",
            "Adobe Minion Web",
            "Agency FB",
            "Aharoni",
            "Aldhabi",
            "Algerian",
            "Almanac MT",
            "American Uncial",
            "Andale Mono",
            "Andalus",
            "Andy",
            "Angsana New",
            "AngsanaUPC",
            "Aparajita",
            "Arabic Transparent",
            "Arabic Typesetting",
            "Arial",
            "Arial Black",
            "Arial Narrow",
            "Arial Narrow Special",
            "Arial Rounded MT",
            "Arial Special",
            "Arial Unicode MS",
            "Augsburger Initials",
            "Baskerville Old Face",
            "Batang",
            "BatangChe",
            "Bauhaus 93",
            "Beesknees ITC",
            "Bell MT",
            "Berlin Sans FB",
            "Bernard MT Condensed",
            "Bickley Script",
            "Blackadder ITC",
            "Bodoni MT",
            "Bodoni MT Condensed",
            "Bon Apetit MT",
            "Book Antiqua",
            "Bookman Old Style",
            "Bookshelf Symbol",
            "Bradley Hand ITC",
            "Braggadocio",
            "BriemScript",
            "Britannic",
            "Britannic Bold",
            "Broadway",
            "Browallia New",
            "BrowalliaUPC",
            "Brush Script MT",
            "Calibri",
            "Californian FB",
            "Calisto MT",
            "Cambria",
            "Cambria Math",
            "Candara",
            "Cariadings",
            "Castellar",
            "Centaur",
            "Century",
            "Century Gothic",
            "Century Schoolbook",
            "Chiller",
            "Colonna MT",
            "Comic Sans MS",
            "Consolas",
            "Constantia",
            "Contemporary Brush",
            "Cooper Black",
            "Copperplate Gothic",
            "Corbel",
            "Cordia New",
            "CordiaUPC",
            "Courier New",
            "Curlz MT",
            "DaunPenh",
            "David",
            "Desdemona",
            "DFKai-SB",
            "DilleniaUPC",
            "Directions MT",
            "DokChampa",
            "Dotum",
            "DotumChe",
            "Ebrima",
            "Eckmann",
            "Edda",
            "Edwardian Script ITC",
            "Elephant",
            "Engravers MT",
            "Enviro",
            "Eras ITC",
            "Estrangelo Edessa",
            "EucrosiaUPC",
            "Euphemia",
            "Eurostile",
            "FangSong",
            "Felix Titling",
            "Fine Hand",
            "Fixed Miriam Transparent",
            "Flexure",
            "Footlight MT",
            "Forte",
            "Franklin Gothic",
            "Franklin Gothic Medium",
            "FrankRuehl",
            "FreesiaUPC",
            "Freestyle Script",
            "French Script MT",
            "Futura",
            "Gabriola",
            "Gadugi",
            "Garamond",
            "Garamond MT",
            "Gautami",
            "Georgia",
            "Georgia Ref",
            "Gigi",
            "Gill Sans MT",
            "Gill Sans MT Condensed",
            "Gisha",
            "Gloucester",
            "Goudy Old Style",
            "Goudy Stout",
            "Gradl",
            "Gulim",
            "GulimChe",
            "Gungsuh",
            "GungsuhChe",
            "Haettenschweiler",
            "Harlow Solid Italic",
            "Harrington",
            "High Tower Text",
            "Holidays MT",
            "Impact",
            "Imprint MT Shadow",
            "Informal Roman",
            "IrisUPC",
            "Iskoola Pota",
            "JasmineUPC",
            "Jokerman",
            "Juice ITC",
            "KaiTi",
            "Kalinga",
            "Kartika",
            "Keystrokes MT",
            "Khmer UI",
            "Kino MT",
            "KodchiangUPC",
            "Kokila",
            "Kristen ITC",
            "Kunstler Script",
            "Lao UI",
            "Latha",
            "LCD",
            "Leelawadee",
            "Levenim MT",
            "LilyUPC",
            "Lucida Blackletter",
            "Lucida Bright",
            "Lucida Bright Math",
            "Lucida Calligraphy",
            "Lucida Console",
            "Lucida Fax",
            "Lucida Handwriting",
            "Lucida Sans",
            "Lucida Sans Typewriter",
            "Lucida Sans Unicode",
            "Magneto",
            "Maiandra GD",
            "Malgun Gothic",
            "Mangal",
            "Map Symbols",
            "Marlett",
            "Matisse ITC",
            "Matura MT Script Capitals",
            "McZee",
            "Mead Bold",
            "Meiryo",
            "Meiryo UI",
            "Mercurius Script MT Bold",
            "Microsoft Himalaya",
            "Microsoft JhengHei",
            "Microsoft JhengHei UI",
            "Microsoft New Tai Lue",
            "Microsoft PhagsPa",
            "Microsoft Sans Serif",
            "Microsoft Tai Le",
            "Microsoft Uighur",
            "Microsoft YaHei",
            "Microsoft YaHei UI",
            "Microsoft Yi Baiti",
            "MingLiU",
            "MingLiU_HKSCS",
            "MingLiU_HKSCS-ExtB",
            "MingLiU-ExtB",
            "Minion Web",
            "Miriam",
            "Miriam Fixed",
            "Mistral",
            "Modern No. 20",
            "Mongolian Baiti",
            "Monotype Corsiva",
            "Monotype Sorts",
            "Monotype.com",
            "MoolBoran",
            "MS Gothic",
            "MS LineDraw",
            "MS Mincho",
            "MS Outlook",
            "MS PGothic",
            "MS PMincho",
            "MS Reference",
            "MS UI Gothic",
            "MT Extra",
            "MV Boli",
            "Myanmar Text",
            "Narkisim",
            "New Caledonia",
            "News Gothic MT",
            "Niagara",
            "Nirmala UI",
            "NSimSun",
            "Nyala",
            "OCR A Extended",
            "OCRB",
            "OCR-B-Digits",
            "Old English Text MT",
            "Onyx",
            "Palace Script MT",
            "Palatino Linotype",
            "Papyrus",
            "Parade",
            "Parchment",
            "Parties MT",
            "Peignot Medium",
            "Pepita MT",
            "Perpetua",
            "Perpetua Titling MT",
            "Placard Condensed",
            "Plantagenet Cherokee",
            "Playbill",
            "PMingLiU",
            "PMingLiU-ExtB",
            "Poor Richard",
            "Pristina",
            "Raavi",
            "Rage Italic",
            "Ransom",
            "Ravie",
            "RefSpecialty",
            "Rockwell",
            "Rockwell Condensed",
            "Rockwell Extra Bold",
            "Rod",
            "Runic MT Condensed",
            "Sakkal Majalla",
            "Script MT Bold",
            "Segoe Chess",
            "Segoe Print",
            "Segoe Pseudo",
            "Segoe Script",
            "Segoe UI",
            "Segoe UI Symbol",
            "Shonar Bangla",
            "Showcard Gothic",
            "Shruti",
            "Signs MT",
            "SimHei",
            "Simplified Arabic",
            "Simplified Arabic Fixed",
            "SimSun",
            "SimSun-ExtB",
            "Snap ITC",
            "Sports MT",
            "Stencil",
            "Stop",
            "Sylfaen",
            "Symbol",
            "Tahoma",
            "Temp Installer Font",
            "Tempo Grunge",
            "Tempus Sans ITC",
            "Times New Roman",
            "Times New Roman Special",
            "Traditional Arabic",
            "Transport MT",
            "Trebuchet MS",
            "Tunga",
            "Tw Cen MT",
            "Tw Cen MT Condensed",
            "Urdu Typesetting",
            "Utsaah",
            "Vacation MT",
            "Vani",
            "Verdana",
            "Verdana Ref",
            "Vijaya",
            "Viner Hand ITC",
            "Vivaldi",
            "Vixar ASCI",
            "Vladimir Script",
            "Vrinda",
            "Webdings",
            "Westminster",
            "Wide Latin",
            "Wingdings"});
            this.TextType.Name = "TextType";
            this.TextType.Size = new System.Drawing.Size(121, 21);
            this.TextType.SelectedIndexChanged += new System.EventHandler(this.FontStyle_SelectedIndexChanged);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldToolStripMenuItem1,
            this.italicToolStripMenuItem1,
            this.regularToolStripMenuItem1,
            this.highlightToolStripMenuItem,
            this.underlineToolStripMenuItem,
            this.strikeoutToolStripMenuItem});
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.textToolStripMenuItem.Text = "&Text";
            // 
            // boldToolStripMenuItem1
            // 
            this.boldToolStripMenuItem1.Name = "boldToolStripMenuItem1";
            this.boldToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.boldToolStripMenuItem1.Text = "&Bold";
            this.boldToolStripMenuItem1.Click += new System.EventHandler(this.boldToolStripMenuItem1_Click);
            // 
            // italicToolStripMenuItem1
            // 
            this.italicToolStripMenuItem1.Name = "italicToolStripMenuItem1";
            this.italicToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.italicToolStripMenuItem1.Text = "&Italic";
            this.italicToolStripMenuItem1.Click += new System.EventHandler(this.italicToolStripMenuItem1_Click);
            // 
            // regularToolStripMenuItem1
            // 
            this.regularToolStripMenuItem1.Name = "regularToolStripMenuItem1";
            this.regularToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.regularToolStripMenuItem1.Text = "&Regular";
            this.regularToolStripMenuItem1.Click += new System.EventHandler(this.regularToolStripMenuItem1_Click);
            // 
            // highlightToolStripMenuItem
            // 
            this.highlightToolStripMenuItem.Name = "highlightToolStripMenuItem";
            this.highlightToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.highlightToolStripMenuItem.Text = "&Highlight";
            this.highlightToolStripMenuItem.Click += new System.EventHandler(this.highlightToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // txtContent
            // 
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.HideSelection = false;
            this.txtContent.Location = new System.Drawing.Point(0, 24);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(657, 425);
            this.txtContent.TabIndex = 1;
            this.txtContent.Text = "";
            this.txtContent.WordWrap = false;
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "text files |*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "text files |*.txt";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripWordCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(657, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripWordCount
            // 
            this.StripWordCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.StripWordCount.Name = "StripWordCount";
            this.StripWordCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StripWordCount.Size = new System.Drawing.Size(78, 17);
            this.StripWordCount.Text = "Word Count: 0";
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.underlineToolStripMenuItem.Text = "&Underline";
            this.underlineToolStripMenuItem.Click += new System.EventHandler(this.underlineToolStripMenuItem_Click);
            // 
            // strikeoutToolStripMenuItem
            // 
            this.strikeoutToolStripMenuItem.Name = "strikeoutToolStripMenuItem";
            this.strikeoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.strikeoutToolStripMenuItem.Text = "&Strikeout";
            this.strikeoutToolStripMenuItem.Click += new System.EventHandler(this.strikeoutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 449);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notepad - Nickolas Reid";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripWordCount;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TextTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox FontSize;
        private System.Windows.Forms.ToolStripComboBox TextType;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem regularToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem highlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strikeoutToolStripMenuItem;
    }
}

