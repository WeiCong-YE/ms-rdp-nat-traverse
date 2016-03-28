﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSRDPNatTraverseClient;

namespace MSRDPNatTraverseClient.Config
{
    /// <summary>
    /// 需要保存配置到磁盘中
    /// 1. 自启动
    /// 2. 关闭后在后台运行
    /// 3. 本机RDP端口信息
    /// 4. 本机标识ID
    /// 5. 本机简单描述
    /// 6. 本机的名称
    /// </summary>
    public class Config
    {
        #region 私有变量
        private bool autoStartUp = false;
        private bool enableBackgroundMode = false;
        Computer.Computer localComputer = null;
        private int selectedServerIndex = -1;
        private int proxyServerListenPort = 9000;
        #endregion

        #region 属性
        public bool AutoStartup
        {
            get
            {
                return autoStartUp;
            }
            set
            {
                autoStartUp = value;
            }
        }

        public bool EnableBackgroundMode
        {
            get
            {
                return enableBackgroundMode;
            }
            set
            {
                enableBackgroundMode = value;
            }
        }

        public Computer.Computer Computer
        {
            get
            {
                return localComputer;
            }
            set
            {
                localComputer = value;
            }
        }

        public int SelectedServerIndex
        {
            get
            {
                return selectedServerIndex;
            }
            set
            {
                selectedServerIndex = value;
            }
        }

        public int ProxyServerListenPort
        {
            get
            {
                return proxyServerListenPort;
            }
            set
            {
                proxyServerListenPort = value;
            }
        }
        #endregion

        #region 构造函数
        public Config() { }
        public Config(bool autoStartup, 
            bool enableBackgroundMode, 
            Computer.Computer computer, 
            int selectedServerIndex,
            int proxyServerListenPort)
        {
            AutoStartup = autoStartup;
            EnableBackgroundMode = enableBackgroundMode;
            Computer = computer;
            SelectedServerIndex = selectedServerIndex;
            ProxyServerListenPort = proxyServerListenPort;
        }
        #endregion
    }

}