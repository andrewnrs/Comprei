namespace Comprei.View
{
    partial class HouseStorageForm
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
            components = new System.ComponentModel.Container();
            houseStorageDataGrid = new DataGridView();
            customerRepositoryBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            perfilToolStripMenuItem = new ToolStripMenuItem();
            alterarMeusDadosToolStripMenuItem = new ToolStripMenuItem();
            alterarDadosDaMinhaCasaToolStripMenuItem = new ToolStripMenuItem();
            obterCódigoDaCasaToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem1 = new ToolStripMenuItem();
            listasDeComprasToolStripMenuItem = new ToolStripMenuItem();
            criarListaDeComprasToolStripMenuItem = new ToolStripMenuItem();
            minhasListasDeComprasToolStripMenuItem = new ToolStripMenuItem();
            listasDeComprasFinalizadasToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)houseStorageDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerRepositoryBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // houseStorageDataGrid
            // 
            houseStorageDataGrid.AllowUserToOrderColumns = true;
            houseStorageDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            houseStorageDataGrid.Location = new Point(12, 34);
            houseStorageDataGrid.Name = "houseStorageDataGrid";
            houseStorageDataGrid.RowTemplate.Height = 25;
            houseStorageDataGrid.Size = new Size(776, 272);
            houseStorageDataGrid.TabIndex = 0;
            houseStorageDataGrid.CellContentClick += houseStorageDataGrid_CellContentClick;
            // 
            // customerRepositoryBindingSource
            // 
            customerRepositoryBindingSource.DataSource = typeof(Database.Repositories.CustomerRepository);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { perfilToolStripMenuItem, listasDeComprasToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // perfilToolStripMenuItem
            // 
            perfilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alterarMeusDadosToolStripMenuItem, alterarDadosDaMinhaCasaToolStripMenuItem, obterCódigoDaCasaToolStripMenuItem, logoutToolStripMenuItem1 });
            perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            perfilToolStripMenuItem.Size = new Size(46, 20);
            perfilToolStripMenuItem.Text = "Perfil";
            // 
            // alterarMeusDadosToolStripMenuItem
            // 
            alterarMeusDadosToolStripMenuItem.Name = "alterarMeusDadosToolStripMenuItem";
            alterarMeusDadosToolStripMenuItem.Size = new Size(225, 22);
            alterarMeusDadosToolStripMenuItem.Text = "Alterar meus dados";
            // 
            // alterarDadosDaMinhaCasaToolStripMenuItem
            // 
            alterarDadosDaMinhaCasaToolStripMenuItem.Name = "alterarDadosDaMinhaCasaToolStripMenuItem";
            alterarDadosDaMinhaCasaToolStripMenuItem.Size = new Size(225, 22);
            alterarDadosDaMinhaCasaToolStripMenuItem.Text = "Alterar dados da minha Casa";
            // 
            // obterCódigoDaCasaToolStripMenuItem
            // 
            obterCódigoDaCasaToolStripMenuItem.Name = "obterCódigoDaCasaToolStripMenuItem";
            obterCódigoDaCasaToolStripMenuItem.Size = new Size(225, 22);
            obterCódigoDaCasaToolStripMenuItem.Text = "Obter código da casa";
            // 
            // logoutToolStripMenuItem1
            // 
            logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            logoutToolStripMenuItem1.Size = new Size(225, 22);
            logoutToolStripMenuItem1.Text = "Sair";
            // 
            // listasDeComprasToolStripMenuItem
            // 
            listasDeComprasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criarListaDeComprasToolStripMenuItem, minhasListasDeComprasToolStripMenuItem, listasDeComprasFinalizadasToolStripMenuItem });
            listasDeComprasToolStripMenuItem.Name = "listasDeComprasToolStripMenuItem";
            listasDeComprasToolStripMenuItem.Size = new Size(115, 20);
            listasDeComprasToolStripMenuItem.Text = "Listas de Compras";
            // 
            // criarListaDeComprasToolStripMenuItem
            // 
            criarListaDeComprasToolStripMenuItem.Name = "criarListaDeComprasToolStripMenuItem";
            criarListaDeComprasToolStripMenuItem.Size = new Size(230, 22);
            criarListaDeComprasToolStripMenuItem.Text = "Criar Lista de Compras";
            // 
            // minhasListasDeComprasToolStripMenuItem
            // 
            minhasListasDeComprasToolStripMenuItem.Name = "minhasListasDeComprasToolStripMenuItem";
            minhasListasDeComprasToolStripMenuItem.Size = new Size(230, 22);
            minhasListasDeComprasToolStripMenuItem.Text = "Minhas Listas de Compras";
            // 
            // listasDeComprasFinalizadasToolStripMenuItem
            // 
            listasDeComprasFinalizadasToolStripMenuItem.Name = "listasDeComprasFinalizadasToolStripMenuItem";
            listasDeComprasFinalizadasToolStripMenuItem.Size = new Size(230, 22);
            listasDeComprasFinalizadasToolStripMenuItem.Text = "Listas de Compras Finalizadas";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(38, 20);
            logoutToolStripMenuItem.Text = "Sair";
            // 
            // HouseStorageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(houseStorageDataGrid);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "HouseStorageForm";
            Text = "HouseStorageForm";
            Load += HouseStorageForm_Load;
            ((System.ComponentModel.ISupportInitialize)houseStorageDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerRepositoryBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView houseStorageDataGrid;
        private BindingSource customerRepositoryBindingSource;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private ToolStripMenuItem listasDeComprasToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem alterarMeusDadosToolStripMenuItem;
        private ToolStripMenuItem alterarDadosDaMinhaCasaToolStripMenuItem;
        private ToolStripMenuItem obterCódigoDaCasaToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem1;
        private ToolStripMenuItem criarListaDeComprasToolStripMenuItem;
        private ToolStripMenuItem minhasListasDeComprasToolStripMenuItem;
        private ToolStripMenuItem listasDeComprasFinalizadasToolStripMenuItem;
    }
}