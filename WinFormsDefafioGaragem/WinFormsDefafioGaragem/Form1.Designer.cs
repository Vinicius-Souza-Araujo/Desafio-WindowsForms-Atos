namespace WinFormsDefafioGaragem
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxPlaca = new TextBox();
            labelPlaca = new Label();
            buttonEntrada = new Button();
            buttonSaida = new Button();
            labelHoraEntrada = new Label();
            labelHoraSaida = new Label();
            buttonEnviar = new Button();
            maskedTextBoxHoraEntrada = new MaskedTextBox();
            maskedTextBoxHoraSaida = new MaskedTextBox();
            labelDataEntrada = new Label();
            textBoxDataEntrada = new TextBox();
            labelDataSaida = new Label();
            textBoxDataSaida = new TextBox();
            bindingSource1 = new BindingSource(components);
            comboBoxVeiculo = new ComboBox();
            labelVeiculo = new Label();
            textBoxMultiploEntrada = new TextBox();
            labelVagasUtilizadas = new Label();
            labelQuantidadeVagas = new Label();
            labelQuantidadeMax = new Label();
            labelVeiculosGaragem = new Label();
            labelSaidaVeiculos = new Label();
            textBoxMultiploSaida = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.BackColor = Color.FromArgb(43, 53, 93);
            textBoxPlaca.BorderStyle = BorderStyle.None;
            textBoxPlaca.CharacterCasing = CharacterCasing.Upper;
            textBoxPlaca.ForeColor = SystemColors.Window;
            textBoxPlaca.Location = new Point(269, 314);
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.Size = new Size(289, 16);
            textBoxPlaca.TabIndex = 0;
            // 
            // labelPlaca
            // 
            labelPlaca.AutoSize = true;
            labelPlaca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlaca.ForeColor = SystemColors.ControlLight;
            labelPlaca.Location = new Point(269, 296);
            labelPlaca.Name = "labelPlaca";
            labelPlaca.Size = new Size(38, 15);
            labelPlaca.TabIndex = 1;
            labelPlaca.Text = "Placa:";
            // 
            // buttonEntrada
            // 
            buttonEntrada.BackColor = Color.FromArgb(143, 160, 249);
            buttonEntrada.FlatAppearance.BorderSize = 0;
            buttonEntrada.FlatStyle = FlatStyle.Flat;
            buttonEntrada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEntrada.ForeColor = SystemColors.ControlLight;
            buttonEntrada.Location = new Point(269, 348);
            buttonEntrada.Name = "buttonEntrada";
            buttonEntrada.Size = new Size(127, 23);
            buttonEntrada.TabIndex = 2;
            buttonEntrada.Text = "Entrada";
            buttonEntrada.UseVisualStyleBackColor = false;
            buttonEntrada.Click += buttonEntrada_Click;
            // 
            // buttonSaida
            // 
            buttonSaida.BackColor = Color.FromArgb(143, 160, 249);
            buttonSaida.FlatAppearance.BorderSize = 0;
            buttonSaida.FlatStyle = FlatStyle.Flat;
            buttonSaida.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSaida.ForeColor = SystemColors.ControlLight;
            buttonSaida.Location = new Point(440, 348);
            buttonSaida.Name = "buttonSaida";
            buttonSaida.Size = new Size(118, 23);
            buttonSaida.TabIndex = 3;
            buttonSaida.Text = "Saída";
            buttonSaida.UseVisualStyleBackColor = false;
            buttonSaida.Click += buttonSaida_Click;
            // 
            // labelHoraEntrada
            // 
            labelHoraEntrada.AutoSize = true;
            labelHoraEntrada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelHoraEntrada.ForeColor = SystemColors.ControlLight;
            labelHoraEntrada.Location = new Point(269, 388);
            labelHoraEntrada.Name = "labelHoraEntrada";
            labelHoraEntrada.Size = new Size(100, 15);
            labelHoraEntrada.TabIndex = 5;
            labelHoraEntrada.Text = "Hora de entrada:";
            // 
            // labelHoraSaida
            // 
            labelHoraSaida.AutoSize = true;
            labelHoraSaida.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelHoraSaida.ForeColor = SystemColors.ControlLight;
            labelHoraSaida.Location = new Point(440, 388);
            labelHoraSaida.Name = "labelHoraSaida";
            labelHoraSaida.Size = new Size(84, 15);
            labelHoraSaida.TabIndex = 7;
            labelHoraSaida.Text = "Hora de saída:";
            // 
            // buttonEnviar
            // 
            buttonEnviar.BackColor = Color.FromArgb(143, 160, 249);
            buttonEnviar.FlatAppearance.BorderSize = 0;
            buttonEnviar.FlatStyle = FlatStyle.Flat;
            buttonEnviar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEnviar.ForeColor = SystemColors.ControlLight;
            buttonEnviar.Location = new Point(269, 517);
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(289, 23);
            buttonEnviar.TabIndex = 8;
            buttonEnviar.Text = "Enviar";
            buttonEnviar.UseVisualStyleBackColor = false;
            buttonEnviar.Click += buttonEnviar_Click;
            // 
            // maskedTextBoxHoraEntrada
            // 
            maskedTextBoxHoraEntrada.Enabled = false;
            maskedTextBoxHoraEntrada.Location = new Point(269, 406);
            maskedTextBoxHoraEntrada.Mask = "00:00";
            maskedTextBoxHoraEntrada.Name = "maskedTextBoxHoraEntrada";
            maskedTextBoxHoraEntrada.Size = new Size(127, 23);
            maskedTextBoxHoraEntrada.TabIndex = 9;
            maskedTextBoxHoraEntrada.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBoxHoraSaida
            // 
            maskedTextBoxHoraSaida.Enabled = false;
            maskedTextBoxHoraSaida.Location = new Point(440, 406);
            maskedTextBoxHoraSaida.Mask = "00:00";
            maskedTextBoxHoraSaida.Name = "maskedTextBoxHoraSaida";
            maskedTextBoxHoraSaida.Size = new Size(117, 23);
            maskedTextBoxHoraSaida.TabIndex = 10;
            maskedTextBoxHoraSaida.ValidatingType = typeof(DateTime);
            // 
            // labelDataEntrada
            // 
            labelDataEntrada.AutoSize = true;
            labelDataEntrada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDataEntrada.ForeColor = SystemColors.ControlLight;
            labelDataEntrada.Location = new Point(268, 442);
            labelDataEntrada.Name = "labelDataEntrada";
            labelDataEntrada.Size = new Size(99, 15);
            labelDataEntrada.TabIndex = 11;
            labelDataEntrada.Text = "Data de entrada:";
            // 
            // textBoxDataEntrada
            // 
            textBoxDataEntrada.Enabled = false;
            textBoxDataEntrada.Location = new Point(269, 460);
            textBoxDataEntrada.Name = "textBoxDataEntrada";
            textBoxDataEntrada.Size = new Size(127, 23);
            textBoxDataEntrada.TabIndex = 12;
            // 
            // labelDataSaida
            // 
            labelDataSaida.AutoSize = true;
            labelDataSaida.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDataSaida.ForeColor = SystemColors.ControlLight;
            labelDataSaida.Location = new Point(441, 442);
            labelDataSaida.Name = "labelDataSaida";
            labelDataSaida.Size = new Size(83, 15);
            labelDataSaida.TabIndex = 13;
            labelDataSaida.Text = "Data de saída:";
            // 
            // textBoxDataSaida
            // 
            textBoxDataSaida.Enabled = false;
            textBoxDataSaida.Location = new Point(440, 460);
            textBoxDataSaida.Name = "textBoxDataSaida";
            textBoxDataSaida.Size = new Size(117, 23);
            textBoxDataSaida.TabIndex = 14;
            // 
            // comboBoxVeiculo
            // 
            comboBoxVeiculo.BackColor = Color.FromArgb(43, 53, 93);
            comboBoxVeiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVeiculo.FormattingEnabled = true;
            comboBoxVeiculo.Items.AddRange(new object[] { "moto", "carro", "caminhonete" });
            comboBoxVeiculo.Location = new Point(269, 263);
            comboBoxVeiculo.Name = "comboBoxVeiculo";
            comboBoxVeiculo.Size = new Size(289, 23);
            comboBoxVeiculo.TabIndex = 15;
            // 
            // labelVeiculo
            // 
            labelVeiculo.AutoSize = true;
            labelVeiculo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelVeiculo.ForeColor = SystemColors.ControlLight;
            labelVeiculo.Location = new Point(269, 245);
            labelVeiculo.Name = "labelVeiculo";
            labelVeiculo.Size = new Size(50, 15);
            labelVeiculo.TabIndex = 16;
            labelVeiculo.Text = "Veiculo:";
            // 
            // textBoxMultiploEntrada
            // 
            textBoxMultiploEntrada.BackColor = Color.FromArgb(43, 53, 93);
            textBoxMultiploEntrada.BorderStyle = BorderStyle.None;
            textBoxMultiploEntrada.ForeColor = SystemColors.Window;
            textBoxMultiploEntrada.Location = new Point(606, 263);
            textBoxMultiploEntrada.Multiline = true;
            textBoxMultiploEntrada.Name = "textBoxMultiploEntrada";
            textBoxMultiploEntrada.ReadOnly = true;
            textBoxMultiploEntrada.ScrollBars = ScrollBars.Vertical;
            textBoxMultiploEntrada.Size = new Size(281, 277);
            textBoxMultiploEntrada.TabIndex = 17;
            // 
            // labelVagasUtilizadas
            // 
            labelVagasUtilizadas.AutoSize = true;
            labelVagasUtilizadas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelVagasUtilizadas.ForeColor = SystemColors.ControlLight;
            labelVagasUtilizadas.Location = new Point(604, 227);
            labelVagasUtilizadas.Name = "labelVagasUtilizadas";
            labelVagasUtilizadas.Size = new Size(95, 15);
            labelVagasUtilizadas.TabIndex = 18;
            labelVagasUtilizadas.Text = "Vagas utilizadas:";
            // 
            // labelQuantidadeVagas
            // 
            labelQuantidadeVagas.AutoSize = true;
            labelQuantidadeVagas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelQuantidadeVagas.ForeColor = SystemColors.ControlLight;
            labelQuantidadeVagas.Location = new Point(702, 227);
            labelQuantidadeVagas.Name = "labelQuantidadeVagas";
            labelQuantidadeVagas.Size = new Size(14, 15);
            labelQuantidadeVagas.TabIndex = 19;
            labelQuantidadeVagas.Text = "0";
            labelQuantidadeVagas.Click += labelQuantidadeVagas_Click;
            // 
            // labelQuantidadeMax
            // 
            labelQuantidadeMax.AutoSize = true;
            labelQuantidadeMax.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelQuantidadeMax.ForeColor = SystemColors.ControlLight;
            labelQuantidadeMax.Location = new Point(721, 227);
            labelQuantidadeMax.Name = "labelQuantidadeMax";
            labelQuantidadeMax.Size = new Size(38, 15);
            labelQuantidadeMax.TabIndex = 20;
            labelQuantidadeMax.Text = "/    50";
            labelQuantidadeMax.Click += labelQuantidadeMax_Click;
            // 
            // labelVeiculosGaragem
            // 
            labelVeiculosGaragem.AutoSize = true;
            labelVeiculosGaragem.BackColor = Color.FromArgb(95, 117, 172);
            labelVeiculosGaragem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelVeiculosGaragem.ForeColor = SystemColors.ControlLight;
            labelVeiculosGaragem.Location = new Point(606, 245);
            labelVeiculosGaragem.Name = "labelVeiculosGaragem";
            labelVeiculosGaragem.Size = new Size(123, 15);
            labelVeiculosGaragem.TabIndex = 21;
            labelVeiculosGaragem.Text = "Veiculos na garagem:";
            // 
            // labelSaidaVeiculos
            // 
            labelSaidaVeiculos.AutoSize = true;
            labelSaidaVeiculos.BackColor = Color.FromArgb(95, 117, 172);
            labelSaidaVeiculos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSaidaVeiculos.ForeColor = SystemColors.ControlLight;
            labelSaidaVeiculos.Location = new Point(915, 245);
            labelSaidaVeiculos.Name = "labelSaidaVeiculos";
            labelSaidaVeiculos.Size = new Size(104, 15);
            labelSaidaVeiculos.TabIndex = 22;
            labelSaidaVeiculos.Text = "Saida de veiculos:";
            // 
            // textBoxMultiploSaida
            // 
            textBoxMultiploSaida.BackColor = Color.FromArgb(43, 53, 93);
            textBoxMultiploSaida.BorderStyle = BorderStyle.None;
            textBoxMultiploSaida.ForeColor = SystemColors.Window;
            textBoxMultiploSaida.Location = new Point(915, 263);
            textBoxMultiploSaida.Multiline = true;
            textBoxMultiploSaida.Name = "textBoxMultiploSaida";
            textBoxMultiploSaida.ReadOnly = true;
            textBoxMultiploSaida.ScrollBars = ScrollBars.Vertical;
            textBoxMultiploSaida.ShortcutsEnabled = false;
            textBoxMultiploSaida.Size = new Size(282, 277);
            textBoxMultiploSaida.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(331, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 116);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 8, 42);
            ClientSize = new Size(1209, 539);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxMultiploSaida);
            Controls.Add(labelSaidaVeiculos);
            Controls.Add(labelVeiculosGaragem);
            Controls.Add(labelQuantidadeMax);
            Controls.Add(labelQuantidadeVagas);
            Controls.Add(labelVagasUtilizadas);
            Controls.Add(textBoxMultiploEntrada);
            Controls.Add(labelVeiculo);
            Controls.Add(comboBoxVeiculo);
            Controls.Add(textBoxDataSaida);
            Controls.Add(labelDataSaida);
            Controls.Add(textBoxDataEntrada);
            Controls.Add(labelDataEntrada);
            Controls.Add(maskedTextBoxHoraSaida);
            Controls.Add(maskedTextBoxHoraEntrada);
            Controls.Add(buttonEnviar);
            Controls.Add(labelHoraSaida);
            Controls.Add(labelHoraEntrada);
            Controls.Add(buttonSaida);
            Controls.Add(buttonEntrada);
            Controls.Add(labelPlaca);
            Controls.Add(textBoxPlaca);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPlaca;
        private Label labelPlaca;
        private Button buttonEntrada;
        private Button buttonSaida;
        private Label labelHoraEntrada;
        private Label labelHoraSaida;
        private Button buttonEnviar;
        private MaskedTextBox maskedTextBoxHoraSaida;
        private MaskedTextBox maskedTextBoxHoraEntrada;
        private Label labelDataEntrada;
        private TextBox textBoxDataEntrada;
        private Label labelDataSaida;
        private TextBox textBoxDataSaida;
        private BindingSource bindingSource1;
        private ComboBox comboBoxVeiculo;
        private Label labelVeiculo;
        private TextBox textBoxMultiploEntrada;
        private Label labelVagasUtilizadas;
        private Label labelQuantidadeVagas;
        private Label labelQuantidadeMax;
        private Label labelVeiculosGaragem;
        private Label labelSaidaVeiculos;
        private TextBox textBoxMultiploSaida;
        private PictureBox pictureBox1;
    }
}