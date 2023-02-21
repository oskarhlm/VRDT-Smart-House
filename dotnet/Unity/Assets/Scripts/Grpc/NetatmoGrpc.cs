// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: netatmo.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Netatmo {
  public static partial class Netatmo
  {
    static readonly string __ServiceName = "netatmo.Netatmo";

    static readonly grpc::Marshaller<global::Netatmo.NetatmoRequest> __Marshaller_netatmo_NetatmoRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Netatmo.NetatmoRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Netatmo.NetatmoData> __Marshaller_netatmo_NetatmoData = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Netatmo.NetatmoData.Parser.ParseFrom);

    static readonly grpc::Method<global::Netatmo.NetatmoRequest, global::Netatmo.NetatmoData> __Method_GetData = new grpc::Method<global::Netatmo.NetatmoRequest, global::Netatmo.NetatmoData>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetData",
        __Marshaller_netatmo_NetatmoRequest,
        __Marshaller_netatmo_NetatmoData);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Netatmo.NetatmoReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Netatmo</summary>
    [grpc::BindServiceMethod(typeof(Netatmo), "BindService")]
    public abstract partial class NetatmoBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Netatmo.NetatmoData> GetData(global::Netatmo.NetatmoRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Netatmo</summary>
    public partial class NetatmoClient : grpc::ClientBase<NetatmoClient>
    {
      /// <summary>Creates a new client for Netatmo</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public NetatmoClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Netatmo that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public NetatmoClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected NetatmoClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected NetatmoClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Netatmo.NetatmoData GetData(global::Netatmo.NetatmoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Netatmo.NetatmoData GetData(global::Netatmo.NetatmoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetData, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Netatmo.NetatmoData> GetDataAsync(global::Netatmo.NetatmoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetDataAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Netatmo.NetatmoData> GetDataAsync(global::Netatmo.NetatmoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetData, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override NetatmoClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new NetatmoClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(NetatmoBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetData, serviceImpl.GetData).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, NetatmoBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetData, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Netatmo.NetatmoRequest, global::Netatmo.NetatmoData>(serviceImpl.GetData));
    }

  }
}
#endregion