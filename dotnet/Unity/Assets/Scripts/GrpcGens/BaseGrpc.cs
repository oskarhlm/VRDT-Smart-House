// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: base.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcBase {
  public static partial class Netatmo
  {
    static readonly string __ServiceName = "grpc_base.Netatmo";

    static readonly grpc::Marshaller<global::GrpcBase.NetatmoMessages.Types.NetatmoRequest> __Marshaller_grpc_base_NetatmoMessages_NetatmoRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcBase.NetatmoMessages.Types.NetatmoRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcBase.NetatmoMessages.Types.NetatmoData> __Marshaller_grpc_base_NetatmoMessages_NetatmoData = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcBase.NetatmoMessages.Types.NetatmoData.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcBase.NetatmoMessages.Types.NetatmoRequest, global::GrpcBase.NetatmoMessages.Types.NetatmoData> __Method_GetData = new grpc::Method<global::GrpcBase.NetatmoMessages.Types.NetatmoRequest, global::GrpcBase.NetatmoMessages.Types.NetatmoData>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetData",
        __Marshaller_grpc_base_NetatmoMessages_NetatmoRequest,
        __Marshaller_grpc_base_NetatmoMessages_NetatmoData);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcBase.BaseReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Netatmo</summary>
    [grpc::BindServiceMethod(typeof(Netatmo), "BindService")]
    public abstract partial class NetatmoBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcBase.NetatmoMessages.Types.NetatmoData> GetData(global::GrpcBase.NetatmoMessages.Types.NetatmoRequest request, grpc::ServerCallContext context)
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

      public virtual global::GrpcBase.NetatmoMessages.Types.NetatmoData GetData(global::GrpcBase.NetatmoMessages.Types.NetatmoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcBase.NetatmoMessages.Types.NetatmoData GetData(global::GrpcBase.NetatmoMessages.Types.NetatmoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetData, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcBase.NetatmoMessages.Types.NetatmoData> GetDataAsync(global::GrpcBase.NetatmoMessages.Types.NetatmoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetDataAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcBase.NetatmoMessages.Types.NetatmoData> GetDataAsync(global::GrpcBase.NetatmoMessages.Types.NetatmoRequest request, grpc::CallOptions options)
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
      serviceBinder.AddMethod(__Method_GetData, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcBase.NetatmoMessages.Types.NetatmoRequest, global::GrpcBase.NetatmoMessages.Types.NetatmoData>(serviceImpl.GetData));
    }

  }
  public static partial class Image
  {
    static readonly string __ServiceName = "grpc_base.Image";

    static readonly grpc::Marshaller<global::GrpcBase.ImageMessages.Types.ImageRequest> __Marshaller_grpc_base_ImageMessages_ImageRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcBase.ImageMessages.Types.ImageRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcBase.ImageMessages.Types.ImageData> __Marshaller_grpc_base_ImageMessages_ImageData = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcBase.ImageMessages.Types.ImageData.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcBase.ImageMessages.Types.ImageRequest, global::GrpcBase.ImageMessages.Types.ImageData> __Method_GetImage = new grpc::Method<global::GrpcBase.ImageMessages.Types.ImageRequest, global::GrpcBase.ImageMessages.Types.ImageData>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetImage",
        __Marshaller_grpc_base_ImageMessages_ImageRequest,
        __Marshaller_grpc_base_ImageMessages_ImageData);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcBase.BaseReflection.Descriptor.Services[1]; }
    }

    /// <summary>Base class for server-side implementations of Image</summary>
    [grpc::BindServiceMethod(typeof(Image), "BindService")]
    public abstract partial class ImageBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcBase.ImageMessages.Types.ImageData> GetImage(global::GrpcBase.ImageMessages.Types.ImageRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Image</summary>
    public partial class ImageClient : grpc::ClientBase<ImageClient>
    {
      /// <summary>Creates a new client for Image</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ImageClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Image that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ImageClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ImageClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ImageClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcBase.ImageMessages.Types.ImageData GetImage(global::GrpcBase.ImageMessages.Types.ImageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetImage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcBase.ImageMessages.Types.ImageData GetImage(global::GrpcBase.ImageMessages.Types.ImageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetImage, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcBase.ImageMessages.Types.ImageData> GetImageAsync(global::GrpcBase.ImageMessages.Types.ImageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetImageAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcBase.ImageMessages.Types.ImageData> GetImageAsync(global::GrpcBase.ImageMessages.Types.ImageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetImage, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ImageClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ImageClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ImageBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetImage, serviceImpl.GetImage).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ImageBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetImage, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcBase.ImageMessages.Types.ImageRequest, global::GrpcBase.ImageMessages.Types.ImageData>(serviceImpl.GetImage));
    }

  }
  public static partial class Disruptive
  {
    static readonly string __ServiceName = "grpc_base.Disruptive";

    static readonly grpc::Marshaller<global::GrpcBase.DisruptiveMessages.Types.Request> __Marshaller_grpc_base_DisruptiveMessages_Request = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcBase.DisruptiveMessages.Types.Request.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcBase.DisruptiveMessages.Types.Response> __Marshaller_grpc_base_DisruptiveMessages_Response = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcBase.DisruptiveMessages.Types.Response.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcBase.DisruptiveMessages.Types.Request, global::GrpcBase.DisruptiveMessages.Types.Response> __Method_GetTemperatureStream = new grpc::Method<global::GrpcBase.DisruptiveMessages.Types.Request, global::GrpcBase.DisruptiveMessages.Types.Response>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "GetTemperatureStream",
        __Marshaller_grpc_base_DisruptiveMessages_Request,
        __Marshaller_grpc_base_DisruptiveMessages_Response);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcBase.BaseReflection.Descriptor.Services[2]; }
    }

    /// <summary>Base class for server-side implementations of Disruptive</summary>
    [grpc::BindServiceMethod(typeof(Disruptive), "BindService")]
    public abstract partial class DisruptiveBase
    {
      public virtual global::System.Threading.Tasks.Task GetTemperatureStream(grpc::IAsyncStreamReader<global::GrpcBase.DisruptiveMessages.Types.Request> requestStream, grpc::IServerStreamWriter<global::GrpcBase.DisruptiveMessages.Types.Response> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Disruptive</summary>
    public partial class DisruptiveClient : grpc::ClientBase<DisruptiveClient>
    {
      /// <summary>Creates a new client for Disruptive</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DisruptiveClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Disruptive that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DisruptiveClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DisruptiveClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DisruptiveClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncDuplexStreamingCall<global::GrpcBase.DisruptiveMessages.Types.Request, global::GrpcBase.DisruptiveMessages.Types.Response> GetTemperatureStream(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTemperatureStream(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::GrpcBase.DisruptiveMessages.Types.Request, global::GrpcBase.DisruptiveMessages.Types.Response> GetTemperatureStream(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_GetTemperatureStream, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DisruptiveClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DisruptiveClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DisruptiveBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetTemperatureStream, serviceImpl.GetTemperatureStream).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DisruptiveBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetTemperatureStream, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::GrpcBase.DisruptiveMessages.Types.Request, global::GrpcBase.DisruptiveMessages.Types.Response>(serviceImpl.GetTemperatureStream));
    }

  }
}
#endregion
