// Generated by the protocol buffer compiler. DO NOT EDIT!
// source: math.proto
#region Designer generated code

using System;
using System.Threading.Tasks;
using DotBPE.Rpc;
using DotBPE.Protocol.Amp;
using DotBPE.Rpc.Exceptions;
using Google.Protobuf;

namespace MathCommon {

    //start for class MathClient
    public sealed class MathClient : AmpInvokeClient
    {
        public MathClient(IRpcClient<AmpMessage> client) : base(client)
        {
        }
        public MathClient(string remoteAddress) : base(remoteAddress)
        {
        }


        //同步方法
        public RpcResult<AddRes> Add(AddReq req)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(10005, 1);

            message.FriendlyServiceName = "Math.Add";


            message.Data = req.ToByteArray();
            var response = base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<AddRes>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = AddRes.Parser.ParseFrom(response.Data);
            }
            return result;
        }

        public async Task<RpcResult<AddRes>> AddAsync(AddReq req, int timeOut = 3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(10005, 1);
            message.FriendlyServiceName = "Math.Add";
            message.Data = req.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message, timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
           var result = new RpcResult<AddRes>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = AddRes.Parser.ParseFrom(response.Data);
            }

            return result;
        }


    }
    //end for class MathClient
}
#endregion