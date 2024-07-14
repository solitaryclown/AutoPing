using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AutoPing
{
    internal class PingTool
    {
        public long Intervals { get; set; } = 1000;//s

        private System.Threading.Timer timer;
        private Ping ping;
        public  string Host { get; set; }
        public bool isTimerEnabled {  get; set; }=false;
        public PingTool(string host,int intervals)
        {
            Host= host;
            Intervals = intervals;
        }

        public void Start()
        {
            if (isTimerEnabled)
            {
                TimerCallback callback = new TimerCallback(PingOnce);
                timer = new System.Threading.Timer(callback,null,0,Intervals*1000);
            }
            else
            {
                PingOnce(null);
            }
        }
        delegate void InfoDelegate(string info);
        private async void PingOnce(object state)
        {
            ping = new Ping();
            PingReply reply =await ping.SendPingAsync(Host);
            IPStatus status = reply.Status;
            long roundtripTime = reply.RoundtripTime;
            InfoDelegate infoDelegate;
            switch (status)
            {
                case IPStatus.Success:
                    infoDelegate = AppLogger.LogInfo; break;
                default:
                    infoDelegate = AppLogger.LogError; break;
            }
            infoDelegate($"ping {Host}，结果 {status}，用时 {roundtripTime}ms");
        }

        internal void Stop()
        {
            if(isTimerEnabled)
            {
                timer?.Dispose();
            }
        }
    }
}
