﻿namespace gestionDeMonStock
{
    partial class form_menu
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
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_menu = new System.Windows.Forms.Button();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btn_produit = new System.Windows.Forms.Button();
            this.btn_categorie = new System.Windows.Forms.Button();
            this.btn_commande = new System.Windows.Forms.Button();
            this.btn_utilisateur = new System.Windows.Forms.Button();
            this.btn_client = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelParametre = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_parametre = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelParametre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel_menu.Controls.Add(this.btn_menu);
            this.panel_menu.Controls.Add(this.panelBtn);
            this.panel_menu.Controls.Add(this.btn_produit);
            this.panel_menu.Controls.Add(this.btn_categorie);
            this.panel_menu.Controls.Add(this.btn_commande);
            this.panel_menu.Controls.Add(this.btn_utilisateur);
            this.panel_menu.Controls.Add(this.btn_client);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(247, 491);
            this.panel_menu.TabIndex = 0;
            // 
            // btn_menu
            // 
            this.btn_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Image = global::gestionDeMonStock.Properties.Resources.menu_16px;
            this.btn_menu.Location = new System.Drawing.Point(210, 3);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(42, 37);
            this.btn_menu.TabIndex = 2;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // panelBtn
            // 
            this.panelBtn.BackColor = System.Drawing.Color.Maroon;
            this.panelBtn.Location = new System.Drawing.Point(0, 115);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(10, 57);
            this.panelBtn.TabIndex = 2;
            // 
            // btn_produit
            // 
            this.btn_produit.FlatAppearance.BorderSize = 0;
            this.btn_produit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_produit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_produit.Image = global::gestionDeMonStock.Properties.Resources.clear_shopping_cart_40px1;
            this.btn_produit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_produit.Location = new System.Drawing.Point(12, 177);
            this.btn_produit.Name = "btn_produit";
            this.btn_produit.Size = new System.Drawing.Size(240, 57);
            this.btn_produit.TabIndex = 6;
            this.btn_produit.Text = "produit";
            this.btn_produit.UseVisualStyleBackColor = true;
            this.btn_produit.Click += new System.EventHandler(this.btn_produit_Click);
            // 
            // btn_categorie
            // 
            this.btn_categorie.FlatAppearance.BorderSize = 0;
            this.btn_categorie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_categorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_categorie.Image = global::gestionDeMonStock.Properties.Resources.categorize_48px;
            this.btn_categorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categorie.Location = new System.Drawing.Point(12, 240);
            this.btn_categorie.Name = "btn_categorie";
            this.btn_categorie.Size = new System.Drawing.Size(240, 57);
            this.btn_categorie.TabIndex = 5;
            this.btn_categorie.Text = "   catégorie";
            this.btn_categorie.UseVisualStyleBackColor = true;
            this.btn_categorie.Click += new System.EventHandler(this.btn_categorie_Click);
            // 
            // btn_commande
            // 
            this.btn_commande.FlatAppearance.BorderSize = 0;
            this.btn_commande.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_commande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_commande.Image = global::gestionDeMonStock.Properties.Resources.purchase_order_26px;
            this.btn_commande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_commande.Location = new System.Drawing.Point(12, 303);
            this.btn_commande.Name = "btn_commande";
            this.btn_commande.Size = new System.Drawing.Size(240, 57);
            this.btn_commande.TabIndex = 4;
            this.btn_commande.Text = "   commande";
            this.btn_commande.UseVisualStyleBackColor = true;
            this.btn_commande.Click += new System.EventHandler(this.btn_commande_Click);
            // 
            // btn_utilisateur
            // 
            this.btn_utilisateur.FlatAppearance.BorderSize = 0;
            this.btn_utilisateur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_utilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_utilisateur.Image = global::gestionDeMonStock.Properties.Resources.user_shield_48px;
            this.btn_utilisateur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_utilisateur.Location = new System.Drawing.Point(12, 366);
            this.btn_utilisateur.Name = "btn_utilisateur";
            this.btn_utilisateur.Size = new System.Drawing.Size(240, 57);
            this.btn_utilisateur.TabIndex = 3;
            this.btn_utilisateur.Text = "   utilisateur";
            this.btn_utilisateur.UseVisualStyleBackColor = true;
            this.btn_utilisateur.Click += new System.EventHandler(this.btn_utilisateur_Click);
            // 
            // btn_client
            // 
            this.btn_client.FlatAppearance.BorderSize = 0;
            this.btn_client.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_client.Image = global::gestionDeMonStock.Properties.Resources.user_48px;
            this.btn_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_client.Location = new System.Drawing.Point(12, 115);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(240, 57);
            this.btn_client.TabIndex = 2;
            this.btn_client.Text = "client";
            this.btn_client.UseVisualStyleBackColor = true;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Maroon;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(247, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(517, 10);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelParametre);
            this.panelMain.Controls.Add(this.btn_parametre);
            this.panelMain.Controls.Add(this.btn_minimize);
            this.panelMain.Controls.Add(this.btn_fermer);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Lucida Calligraphy", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(247, 10);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(517, 481);
            this.panelMain.TabIndex = 2;
            // 
            // panelParametre
            // 
            this.panelParametre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelParametre.Controls.Add(this.button4);
            this.panelParametre.Controls.Add(this.button3);
            this.panelParametre.Controls.Add(this.button2);
            this.panelParametre.Controls.Add(this.button1);
            this.panelParametre.Location = new System.Drawing.Point(36, 6);
            this.panelParametre.Name = "panelParametre";
            this.panelParametre.Size = new System.Drawing.Size(400, 228);
            this.panelParametre.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Lucida Calligraphy", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::gestionDeMonStock.Properties.Resources.shutdown_24px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(400, 43);
            this.button4.TabIndex = 9;
            this.button4.Text = "déconnecter";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Lucida Calligraphy", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::gestionDeMonStock.Properties.Resources.cloud_backup_restore_24px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(400, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "restaurer une copie enregistrée";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Calligraphy", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::gestionDeMonStock.Properties.Resources.import_24px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(400, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "   creer une copie de l\'application";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Calligraphy", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::gestionDeMonStock.Properties.Resources.connect_24px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "   connecter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_parametre
            // 
            this.btn_parametre.FlatAppearance.BorderSize = 0;
            this.btn_parametre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_parametre.Image = global::gestionDeMonStock.Properties.Resources.settings_24px;
            this.btn_parametre.Location = new System.Drawing.Point(0, 1);
            this.btn_parametre.Name = "btn_parametre";
            this.btn_parametre.Size = new System.Drawing.Size(30, 20);
            this.btn_parametre.TabIndex = 9;
            this.btn_parametre.UseVisualStyleBackColor = true;
            this.btn_parametre.Click += new System.EventHandler(this.btn_parametre_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Image = global::gestionDeMonStock.Properties.Resources.minus_24px;
            this.btn_minimize.Location = new System.Drawing.Point(465, 2);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(13, 20);
            this.btn_minimize.TabIndex = 8;
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_fermer
            // 
            this.btn_fermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fermer.FlatAppearance.BorderSize = 0;
            this.btn_fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fermer.Image = global::gestionDeMonStock.Properties.Resources.delete_16px;
            this.btn_fermer.Location = new System.Drawing.Point(484, 2);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(30, 20);
            this.btn_fermer.TabIndex = 7;
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 491);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel_menu);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "form_menu";
            this.Text = "form_menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_menu.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelParametre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_produit;
        private System.Windows.Forms.Button btn_categorie;
        private System.Windows.Forms.Button btn_commande;
        private System.Windows.Forms.Button btn_utilisateur;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btn_parametre;
        private System.Windows.Forms.Panel panelParametre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}