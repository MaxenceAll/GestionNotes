namespace GestionNotes
{
    partial class FormGestion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEleve = new System.Windows.Forms.TabPage();
            this.groupBoxAjoutEleve = new System.Windows.Forms.GroupBox();
            this.textBoxCheminListe = new System.Windows.Forms.TextBox();
            this.labelCheminListeEleve = new System.Windows.Forms.Label();
            this.buttonChargerListeEleve = new System.Windows.Forms.Button();
            this.buttonSauvegarderListeEleve = new System.Windows.Forms.Button();
            this.textBoxEleveAge = new System.Windows.Forms.TextBox();
            this.labelAgeEleve = new System.Windows.Forms.Label();
            this.buttonModifierEleve = new System.Windows.Forms.Button();
            this.labelElevePrenom = new System.Windows.Forms.Label();
            this.textBoxElevePrenom = new System.Windows.Forms.TextBox();
            this.labelAjoutEleveNom = new System.Windows.Forms.Label();
            this.textBoxEleveNom = new System.Windows.Forms.TextBox();
            this.buttonAjouterEleve = new System.Windows.Forms.Button();
            this.buttonRetirerEleve = new System.Windows.Forms.Button();
            this.tableLayoutPanelEleve = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewEleve = new System.Windows.Forms.DataGridView();
            this.tabPageProfesseur = new System.Windows.Forms.TabPage();
            this.tabPageMatiere = new System.Windows.Forms.TabPage();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageEleve.SuspendLayout();
            this.groupBoxAjoutEleve.SuspendLayout();
            this.tableLayoutPanelEleve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEleve);
            this.tabControl1.Controls.Add(this.tabPageProfesseur);
            this.tabControl1.Controls.Add(this.tabPageMatiere);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageEleve
            // 
            this.tabPageEleve.Controls.Add(this.groupBoxAjoutEleve);
            this.tabPageEleve.Controls.Add(this.tableLayoutPanelEleve);
            this.tabPageEleve.Location = new System.Drawing.Point(4, 24);
            this.tabPageEleve.Name = "tabPageEleve";
            this.tabPageEleve.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEleve.Size = new System.Drawing.Size(879, 458);
            this.tabPageEleve.TabIndex = 0;
            this.tabPageEleve.Text = "Gestion eleves";
            this.tabPageEleve.UseVisualStyleBackColor = true;
            // 
            // groupBoxAjoutEleve
            // 
            this.groupBoxAjoutEleve.Controls.Add(this.textBoxCheminListe);
            this.groupBoxAjoutEleve.Controls.Add(this.labelCheminListeEleve);
            this.groupBoxAjoutEleve.Controls.Add(this.buttonChargerListeEleve);
            this.groupBoxAjoutEleve.Controls.Add(this.buttonSauvegarderListeEleve);
            this.groupBoxAjoutEleve.Controls.Add(this.textBoxEleveAge);
            this.groupBoxAjoutEleve.Controls.Add(this.labelAgeEleve);
            this.groupBoxAjoutEleve.Controls.Add(this.buttonModifierEleve);
            this.groupBoxAjoutEleve.Controls.Add(this.labelElevePrenom);
            this.groupBoxAjoutEleve.Controls.Add(this.textBoxElevePrenom);
            this.groupBoxAjoutEleve.Controls.Add(this.labelAjoutEleveNom);
            this.groupBoxAjoutEleve.Controls.Add(this.textBoxEleveNom);
            this.groupBoxAjoutEleve.Controls.Add(this.buttonAjouterEleve);
            this.groupBoxAjoutEleve.Controls.Add(this.buttonRetirerEleve);
            this.groupBoxAjoutEleve.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxAjoutEleve.Location = new System.Drawing.Point(3, 338);
            this.groupBoxAjoutEleve.Name = "groupBoxAjoutEleve";
            this.groupBoxAjoutEleve.Size = new System.Drawing.Size(873, 117);
            this.groupBoxAjoutEleve.TabIndex = 6;
            this.groupBoxAjoutEleve.TabStop = false;
            this.groupBoxAjoutEleve.Text = "Ajout d\'un eleve :";
            // 
            // textBoxCheminListe
            // 
            this.textBoxCheminListe.Location = new System.Drawing.Point(273, 51);
            this.textBoxCheminListe.Name = "textBoxCheminListe";
            this.textBoxCheminListe.Size = new System.Drawing.Size(471, 23);
            this.textBoxCheminListe.TabIndex = 12;
            // 
            // labelCheminListeEleve
            // 
            this.labelCheminListeEleve.AutoSize = true;
            this.labelCheminListeEleve.Location = new System.Drawing.Point(273, 30);
            this.labelCheminListeEleve.Name = "labelCheminListeEleve";
            this.labelCheminListeEleve.Size = new System.Drawing.Size(163, 15);
            this.labelCheminListeEleve.TabIndex = 6;
            this.labelCheminListeEleve.Text = "Chemin vers la liste en cours :";
            // 
            // buttonChargerListeEleve
            // 
            this.buttonChargerListeEleve.Location = new System.Drawing.Point(567, 26);
            this.buttonChargerListeEleve.Name = "buttonChargerListeEleve";
            this.buttonChargerListeEleve.Size = new System.Drawing.Size(123, 23);
            this.buttonChargerListeEleve.TabIndex = 11;
            this.buttonChargerListeEleve.Text = "Importer une liste ...";
            this.buttonChargerListeEleve.UseVisualStyleBackColor = true;
            this.buttonChargerListeEleve.Click += new System.EventHandler(this.buttonChargerListeEleve_Click);
            // 
            // buttonSauvegarderListeEleve
            // 
            this.buttonSauvegarderListeEleve.Location = new System.Drawing.Point(442, 26);
            this.buttonSauvegarderListeEleve.Name = "buttonSauvegarderListeEleve";
            this.buttonSauvegarderListeEleve.Size = new System.Drawing.Size(119, 23);
            this.buttonSauvegarderListeEleve.TabIndex = 10;
            this.buttonSauvegarderListeEleve.Text = "Exporter une liste...";
            this.buttonSauvegarderListeEleve.UseVisualStyleBackColor = true;
            this.buttonSauvegarderListeEleve.Click += new System.EventHandler(this.buttonSauvegarderListeEleve_Click);
            // 
            // textBoxEleveAge
            // 
            this.textBoxEleveAge.Location = new System.Drawing.Point(167, 79);
            this.textBoxEleveAge.Name = "textBoxEleveAge";
            this.textBoxEleveAge.Size = new System.Drawing.Size(100, 23);
            this.textBoxEleveAge.TabIndex = 6;
            // 
            // labelAgeEleve
            // 
            this.labelAgeEleve.AutoSize = true;
            this.labelAgeEleve.Location = new System.Drawing.Point(127, 83);
            this.labelAgeEleve.Name = "labelAgeEleve";
            this.labelAgeEleve.Size = new System.Drawing.Size(34, 15);
            this.labelAgeEleve.TabIndex = 8;
            this.labelAgeEleve.Text = "Age :";
            // 
            // buttonModifierEleve
            // 
            this.buttonModifierEleve.Location = new System.Drawing.Point(6, 79);
            this.buttonModifierEleve.Name = "buttonModifierEleve";
            this.buttonModifierEleve.Size = new System.Drawing.Size(93, 23);
            this.buttonModifierEleve.TabIndex = 3;
            this.buttonModifierEleve.Text = "Modifier eleve";
            this.buttonModifierEleve.UseVisualStyleBackColor = true;
            // 
            // labelElevePrenom
            // 
            this.labelElevePrenom.AutoSize = true;
            this.labelElevePrenom.Location = new System.Drawing.Point(106, 54);
            this.labelElevePrenom.Name = "labelElevePrenom";
            this.labelElevePrenom.Size = new System.Drawing.Size(55, 15);
            this.labelElevePrenom.TabIndex = 6;
            this.labelElevePrenom.Text = "Prénom :";
            // 
            // textBoxElevePrenom
            // 
            this.textBoxElevePrenom.Location = new System.Drawing.Point(167, 50);
            this.textBoxElevePrenom.Name = "textBoxElevePrenom";
            this.textBoxElevePrenom.Size = new System.Drawing.Size(100, 23);
            this.textBoxElevePrenom.TabIndex = 5;
            // 
            // labelAjoutEleveNom
            // 
            this.labelAjoutEleveNom.AutoSize = true;
            this.labelAjoutEleveNom.Location = new System.Drawing.Point(121, 25);
            this.labelAjoutEleveNom.Name = "labelAjoutEleveNom";
            this.labelAjoutEleveNom.Size = new System.Drawing.Size(40, 15);
            this.labelAjoutEleveNom.TabIndex = 5;
            this.labelAjoutEleveNom.Text = "Nom :";
            // 
            // textBoxEleveNom
            // 
            this.textBoxEleveNom.Location = new System.Drawing.Point(167, 22);
            this.textBoxEleveNom.Name = "textBoxEleveNom";
            this.textBoxEleveNom.Size = new System.Drawing.Size(100, 23);
            this.textBoxEleveNom.TabIndex = 4;
            // 
            // buttonAjouterEleve
            // 
            this.buttonAjouterEleve.Location = new System.Drawing.Point(15, 21);
            this.buttonAjouterEleve.Name = "buttonAjouterEleve";
            this.buttonAjouterEleve.Size = new System.Drawing.Size(84, 23);
            this.buttonAjouterEleve.TabIndex = 1;
            this.buttonAjouterEleve.Text = "Ajouter eleve";
            this.buttonAjouterEleve.UseVisualStyleBackColor = true;
            this.buttonAjouterEleve.Click += new System.EventHandler(this.buttonAjouterEleve_Click);
            // 
            // buttonRetirerEleve
            // 
            this.buttonRetirerEleve.Location = new System.Drawing.Point(15, 50);
            this.buttonRetirerEleve.Name = "buttonRetirerEleve";
            this.buttonRetirerEleve.Size = new System.Drawing.Size(84, 23);
            this.buttonRetirerEleve.TabIndex = 2;
            this.buttonRetirerEleve.Text = "Retirer eleve";
            this.buttonRetirerEleve.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelEleve
            // 
            this.tableLayoutPanelEleve.AutoSize = true;
            this.tableLayoutPanelEleve.ColumnCount = 1;
            this.tableLayoutPanelEleve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelEleve.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelEleve.Controls.Add(this.dataGridViewEleve, 0, 0);
            this.tableLayoutPanelEleve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelEleve.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelEleve.Name = "tableLayoutPanelEleve";
            this.tableLayoutPanelEleve.RowCount = 2;
            this.tableLayoutPanelEleve.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.79646F));
            this.tableLayoutPanelEleve.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.20354F));
            this.tableLayoutPanelEleve.Size = new System.Drawing.Size(873, 452);
            this.tableLayoutPanelEleve.TabIndex = 7;
            // 
            // dataGridViewEleve
            // 
            this.dataGridViewEleve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEleve.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewEleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEleve.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewEleve.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEleve.Name = "dataGridViewEleve";
            this.dataGridViewEleve.RowTemplate.Height = 25;
            this.dataGridViewEleve.Size = new System.Drawing.Size(867, 302);
            this.dataGridViewEleve.TabIndex = 0;
            // 
            // tabPageProfesseur
            // 
            this.tabPageProfesseur.Location = new System.Drawing.Point(4, 24);
            this.tabPageProfesseur.Name = "tabPageProfesseur";
            this.tabPageProfesseur.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfesseur.Size = new System.Drawing.Size(879, 458);
            this.tabPageProfesseur.TabIndex = 1;
            this.tabPageProfesseur.Text = "Gestion professeurs";
            this.tabPageProfesseur.UseVisualStyleBackColor = true;
            // 
            // tabPageMatiere
            // 
            this.tabPageMatiere.Location = new System.Drawing.Point(4, 24);
            this.tabPageMatiere.Name = "tabPageMatiere";
            this.tabPageMatiere.Size = new System.Drawing.Size(879, 458);
            this.tabPageMatiere.TabIndex = 2;
            this.tabPageMatiere.Text = "Gestion matières";
            this.tabPageMatiere.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "eleves.log";
            this.saveFileDialog1.InitialDirectory = "\\\\";
            this.saveFileDialog1.Title = "Choisir une liste d\'élèves à exporter.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "eleves.log";
            this.openFileDialog1.InitialDirectory = "\\\\";
            this.openFileDialog1.Title = "Choisir une liste d\'élèves à importer.";
            // 
            // FormGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 617);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des données :";
            this.tabControl1.ResumeLayout(false);
            this.tabPageEleve.ResumeLayout(false);
            this.tabPageEleve.PerformLayout();
            this.groupBoxAjoutEleve.ResumeLayout(false);
            this.groupBoxAjoutEleve.PerformLayout();
            this.tableLayoutPanelEleve.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEleve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageEleve;
        private TabPage tabPageProfesseur;
        private TabPage tabPageMatiere;
        private GroupBox groupBoxAjoutEleve;
        private Label labelElevePrenom;
        private TextBox textBoxElevePrenom;
        private Label labelAjoutEleveNom;
        private TextBox textBoxEleveNom;
        private Button buttonAjouterEleve;
        private Button buttonRetirerEleve;
        private TableLayoutPanel tableLayoutPanelEleve;
        private TextBox textBoxCheminListe;
        private Label labelCheminListeEleve;
        private Button buttonChargerListeEleve;
        private Button buttonSauvegarderListeEleve;
        private TextBox textBoxEleveAge;
        private Label labelAgeEleve;
        private Button buttonModifierEleve;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private DataGridView dataGridViewEleve;
    }
}