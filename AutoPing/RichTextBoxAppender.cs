using log4net.Appender;
using log4net.Core;
using log4net.Filter;
using log4net.Layout;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPing
{
     class RichTextBoxAppender : AppenderSkeleton
    {
        public RichTextBox rbx;
        public RichTextBoxAppender(ILayout layout = null, RichTextBox richTextBox = null)
        {
            rbx = richTextBox;
            if (layout == null)
            {
                var logPattern = "%d{yyyy-MM-dd HH:mm:ss,fff} -%-5p- %m%n";
                Layout = new PatternLayout(logPattern);
            }
        }

        public override IErrorHandler ErrorHandler { get => base.ErrorHandler; set => base.ErrorHandler = value; }

        public override IFilter FilterHead => base.FilterHead;

        public override ILayout Layout { get => base.Layout; set => base.Layout = value; }

        protected override bool RequiresLayout => base.RequiresLayout;

        public override bool Flush(int millisecondsTimeout)
        {
            return base.Flush(millisecondsTimeout);
        }

        protected override void Append(LoggingEvent loggingEvent)
        {
            Level level = loggingEvent.Level;
            //格式化消息
            string renderedMessage = ((PatternLayout)this.Layout).Format(loggingEvent);
            //向richtextbox添加内容
            AppendToLogBox(level, renderedMessage);
        }

        protected override void Append(LoggingEvent[] loggingEvents)
        {
            base.Append(loggingEvents);
        }

        protected override bool IsAsSevereAsThreshold(Level level)
        {
            return base.IsAsSevereAsThreshold(level);
        }

        protected override void OnClose()
        {
            base.OnClose();
        }

        private void AppendToLogBox(Level level, string msg)
        {
            Color foreColor = Color.Black;
            Color backColor = Color.White;
            if (level == Level.Info)
            {
                ;
            }
            else if (level == Level.Debug)
            {
                foreColor = Color.Gray;
            }
            else if (level == Level.Warn)
            {
                foreColor = Color.Yellow;
            }
            else if (level == Level.Error)
            {
                foreColor = Color.Red;
            }
            else
            {
                foreColor = Color.White;
                backColor = Color.Red;
            }

            rbx?.Invoke(new Action(() =>
            {
                rbx.SelectionStart = rbx.TextLength;
                rbx.SelectionColor = foreColor;
                rbx.SelectionBackColor = (Color)backColor;
                if(rbx.TextLength > 5000) {
                rbx.Clear();}
                rbx.AppendText(msg);
            }));
        }
    }

}
