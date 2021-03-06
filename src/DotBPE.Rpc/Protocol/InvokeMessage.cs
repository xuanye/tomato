using System;
using System.Collections.Generic;
using System.Text;

namespace DotBPE.Rpc.Protocol
{
    public abstract class InvokeMessage
    {
        public InvokeMessageType InvokeMessageType { get; set; }

        public abstract int Length { get; }

        /// <summary>
        /// 服务识别符,定位到某个服务
        /// </summary>
        public abstract string ServiceIdentity { get; }

        /// <summary>
        /// 方法识别符，定位到某个方法
        /// </summary>
        public abstract string MethodIdentifier { get; }

        public abstract bool IsHeartBeat { get; }
    }

    public enum InvokeMessageType : byte
    {
        Request = 1,
        Response = 2,
        Notify = 3,
        InvokeWithoutResponse = 4 //请求且不等待回复
    }
}
