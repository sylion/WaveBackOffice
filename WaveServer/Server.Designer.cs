namespace WaveServer
{
    partial class Server
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Log = new System.Diagnostics.EventLog();
            this.doTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Log)).BeginInit();
            // 
            // doTimer
            // 
            this.doTimer.Interval = 30000;
            // 
            // Server
            // 
            this.ServiceName = "Service1";
            ((System.ComponentModel.ISupportInitialize)(this.Log)).EndInit();

        }

        #endregion

        private System.Diagnostics.EventLog Log;
        private System.Windows.Forms.Timer doTimer;
    }
}
