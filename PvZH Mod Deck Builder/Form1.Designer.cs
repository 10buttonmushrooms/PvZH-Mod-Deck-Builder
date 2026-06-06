namespace PvZH_Mod_Deck_Builder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            filesToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            warningPreferenceToolStripMenuItem = new ToolStripMenuItem();
            wrongDeckSizeToolStripMenuItem = new ToolStripMenuItem();
            classesWarningToolStripMenuItem = new ToolStripMenuItem();
            copiesWarningToolStripMenuItem = new ToolStripMenuItem();
            tokenCardsWarningToolStripMenuItem = new ToolStripMenuItem();
            superpowersWarningToolStripMenuItem = new ToolStripMenuItem();
            bothSidesWarningToolStripMenuItem = new ToolStripMenuItem();
            DeckLoader = new OpenFileDialog();
            DeckSaver = new SaveFileDialog();
            CardSearch = new RichTextBox();
            CardList = new ListBox();
            SearchCardLabel = new Label();
            CardAdder = new Button();
            DeckLabel = new Label();
            DeckListView = new ListBox();
            CardRemover = new Button();
            CopiesList = new ListBox();
            CardCount = new Label();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { filesToolStripMenuItem, optionsToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(714, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            filesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, loadToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            filesToolStripMenuItem.Size = new Size(52, 24);
            filesToolStripMenuItem.Text = "Files";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(242, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click_1;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            loadToolStripMenuItem.Size = new Size(242, 26);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(242, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(242, 26);
            saveAsToolStripMenuItem.Text = "Save As...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { warningPreferenceToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(99, 24);
            optionsToolStripMenuItem.Text = "Preferences";
            // 
            // warningPreferenceToolStripMenuItem
            // 
            warningPreferenceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wrongDeckSizeToolStripMenuItem, classesWarningToolStripMenuItem, copiesWarningToolStripMenuItem, tokenCardsWarningToolStripMenuItem, superpowersWarningToolStripMenuItem, bothSidesWarningToolStripMenuItem });
            warningPreferenceToolStripMenuItem.Name = "warningPreferenceToolStripMenuItem";
            warningPreferenceToolStripMenuItem.Size = new Size(239, 26);
            warningPreferenceToolStripMenuItem.Text = " Illegal Deck Warnings";
            // 
            // wrongDeckSizeToolStripMenuItem
            // 
            wrongDeckSizeToolStripMenuItem.Checked = true;
            wrongDeckSizeToolStripMenuItem.CheckOnClick = true;
            wrongDeckSizeToolStripMenuItem.CheckState = CheckState.Checked;
            wrongDeckSizeToolStripMenuItem.Name = "wrongDeckSizeToolStripMenuItem";
            wrongDeckSizeToolStripMenuItem.Size = new Size(222, 26);
            wrongDeckSizeToolStripMenuItem.Text = "Wrong Deck Size";
            // 
            // classesWarningToolStripMenuItem
            // 
            classesWarningToolStripMenuItem.Checked = true;
            classesWarningToolStripMenuItem.CheckOnClick = true;
            classesWarningToolStripMenuItem.CheckState = CheckState.Checked;
            classesWarningToolStripMenuItem.Name = "classesWarningToolStripMenuItem";
            classesWarningToolStripMenuItem.Size = new Size(222, 26);
            classesWarningToolStripMenuItem.Text = "3+ Classes";
            // 
            // copiesWarningToolStripMenuItem
            // 
            copiesWarningToolStripMenuItem.Checked = true;
            copiesWarningToolStripMenuItem.CheckOnClick = true;
            copiesWarningToolStripMenuItem.CheckState = CheckState.Checked;
            copiesWarningToolStripMenuItem.Name = "copiesWarningToolStripMenuItem";
            copiesWarningToolStripMenuItem.Size = new Size(222, 26);
            copiesWarningToolStripMenuItem.Text = "5+ Copies";
            // 
            // tokenCardsWarningToolStripMenuItem
            // 
            tokenCardsWarningToolStripMenuItem.Checked = true;
            tokenCardsWarningToolStripMenuItem.CheckOnClick = true;
            tokenCardsWarningToolStripMenuItem.CheckState = CheckState.Checked;
            tokenCardsWarningToolStripMenuItem.Name = "tokenCardsWarningToolStripMenuItem";
            tokenCardsWarningToolStripMenuItem.Size = new Size(222, 26);
            tokenCardsWarningToolStripMenuItem.Text = "Token Cards";
            // 
            // superpowersWarningToolStripMenuItem
            // 
            superpowersWarningToolStripMenuItem.Checked = true;
            superpowersWarningToolStripMenuItem.CheckOnClick = true;
            superpowersWarningToolStripMenuItem.CheckState = CheckState.Checked;
            superpowersWarningToolStripMenuItem.Name = "superpowersWarningToolStripMenuItem";
            superpowersWarningToolStripMenuItem.Size = new Size(222, 26);
            superpowersWarningToolStripMenuItem.Text = "Superpowers";
            // 
            // bothSidesWarningToolStripMenuItem
            // 
            bothSidesWarningToolStripMenuItem.Checked = true;
            bothSidesWarningToolStripMenuItem.CheckOnClick = true;
            bothSidesWarningToolStripMenuItem.CheckState = CheckState.Checked;
            bothSidesWarningToolStripMenuItem.Name = "bothSidesWarningToolStripMenuItem";
            bothSidesWarningToolStripMenuItem.Size = new Size(222, 26);
            bothSidesWarningToolStripMenuItem.Text = "Plants and Zombies";
            bothSidesWarningToolStripMenuItem.Click += bothSidesWarningToolStripMenuItem_Click;
            // 
            // DeckLoader
            // 
            DeckLoader.Filter = "JSON File|*.json|Text File|*.txt|All Files|*.*";
            DeckLoader.FileOk += DeckLoader_FileOk;
            // 
            // DeckSaver
            // 
            DeckSaver.Filter = "JSON File|*.json|Text File|*.txt|All Files|*.*";
            DeckSaver.FileOk += DeckSaver_FileOk;
            // 
            // CardSearch
            // 
            CardSearch.Location = new Point(33, 78);
            CardSearch.Multiline = false;
            CardSearch.Name = "CardSearch";
            CardSearch.ScrollBars = RichTextBoxScrollBars.None;
            CardSearch.Size = new Size(320, 30);
            CardSearch.TabIndex = 2;
            CardSearch.Text = "";
            CardSearch.TextChanged += CardSearch_TextChanged;
            // 
            // CardList
            // 
            CardList.DisplayMember = "Name";
            CardList.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CardList.FormattingEnabled = true;
            CardList.Location = new Point(33, 114);
            CardList.Name = "CardList";
            CardList.Size = new Size(320, 441);
            CardList.TabIndex = 3;
            CardList.ValueMember = "Value";
            CardList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // SearchCardLabel
            // 
            SearchCardLabel.AutoSize = true;
            SearchCardLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchCardLabel.Location = new Point(33, 55);
            SearchCardLabel.Name = "SearchCardLabel";
            SearchCardLabel.Size = new Size(152, 20);
            SearchCardLabel.TabIndex = 5;
            SearchCardLabel.Text = "Search Cards To Add";
            SearchCardLabel.Click += SearchCardLabel_Click;
            // 
            // CardAdder
            // 
            CardAdder.Location = new Point(33, 561);
            CardAdder.Name = "CardAdder";
            CardAdder.Size = new Size(320, 32);
            CardAdder.TabIndex = 6;
            CardAdder.Text = "Add to Deck";
            CardAdder.UseVisualStyleBackColor = true;
            CardAdder.Click += CardAdder_Click;
            // 
            // DeckLabel
            // 
            DeckLabel.AutoSize = true;
            DeckLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeckLabel.Location = new Point(359, 55);
            DeckLabel.Name = "DeckLabel";
            DeckLabel.Size = new Size(103, 20);
            DeckLabel.TabIndex = 7;
            DeckLabel.Text = "Cards in Deck";
            // 
            // DeckListView
            // 
            DeckListView.FormattingEnabled = true;
            DeckListView.IntegralHeight = false;
            DeckListView.Location = new Point(359, 78);
            DeckListView.Name = "DeckListView";
            DeckListView.Size = new Size(320, 477);
            DeckListView.TabIndex = 10;
            DeckListView.SelectedIndexChanged += DeckListView_SelectedIndexChanged;
            // 
            // CardRemover
            // 
            CardRemover.Location = new Point(359, 561);
            CardRemover.Name = "CardRemover";
            CardRemover.Size = new Size(320, 32);
            CardRemover.TabIndex = 9;
            CardRemover.Text = "Remove from Deck";
            CardRemover.UseVisualStyleBackColor = true;
            CardRemover.Click += CardRemover_Click;
            // 
            // CopiesList
            // 
            CopiesList.Font = new Font("Segoe UI", 9F);
            CopiesList.FormattingEnabled = true;
            CopiesList.IntegralHeight = false;
            CopiesList.Location = new Point(639, 78);
            CopiesList.Name = "CopiesList";
            CopiesList.SelectionMode = SelectionMode.None;
            CopiesList.Size = new Size(40, 477);
            CopiesList.TabIndex = 13;
            // 
            // CardCount
            // 
            CardCount.AutoSize = true;
            CardCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CardCount.Location = new Point(639, 55);
            CardCount.Name = "CardCount";
            CardCount.Size = new Size(18, 20);
            CardCount.TabIndex = 14;
            CardCount.Text = "0";
            CardCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 619);
            Controls.Add(CardCount);
            Controls.Add(CopiesList);
            Controls.Add(DeckListView);
            Controls.Add(CardRemover);
            Controls.Add(DeckLabel);
            Controls.Add(CardAdder);
            Controls.Add(SearchCardLabel);
            Controls.Add(CardList);
            Controls.Add(CardSearch);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Deck Creator/Editor for PvZH Mods";
            Load += Form1_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem filesToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem warningPreferenceToolStripMenuItem;
        private ToolStripMenuItem classesWarningToolStripMenuItem;
        private ToolStripMenuItem copiesWarningToolStripMenuItem;
        private ToolStripMenuItem bothSidesWarningToolStripMenuItem;
        private ToolStripMenuItem tokenCardsWarningToolStripMenuItem;
        private ToolStripMenuItem superpowersWarningToolStripMenuItem;
        private ToolStripMenuItem wrongDeckSizeToolStripMenuItem;
        private OpenFileDialog DeckLoader;
        private SaveFileDialog DeckSaver;
        private RichTextBox CardSearch;
        private ListBox CardList;
        private Label SearchCardLabel;
        private Button CardAdder;
        private Label DeckLabel;
        private ListBox DeckListView;
        private Button CardRemover;
        private ListBox CopiesList;
        private Label CardCount;
    }
}
