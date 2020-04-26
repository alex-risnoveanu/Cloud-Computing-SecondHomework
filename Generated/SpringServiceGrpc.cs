// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SpringService.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Generated {
  public static partial class SpringService
  {
    static readonly string __ServiceName = "SpringService";

    static readonly grpc::Marshaller<global::Generated.SpringRequest> __Marshaller_SpringRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Generated.SpringRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Generated.HoroscopResponse> __Marshaller_HoroscopResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Generated.HoroscopResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Generated.SpringRequest, global::Generated.HoroscopResponse> __Method_getZodiacSign = new grpc::Method<global::Generated.SpringRequest, global::Generated.HoroscopResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "getZodiacSign",
        __Marshaller_SpringRequest,
        __Marshaller_HoroscopResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Generated.SpringServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SpringService</summary>
    [grpc::BindServiceMethod(typeof(SpringService), "BindService")]
    public abstract partial class SpringServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Generated.HoroscopResponse> getZodiacSign(global::Generated.SpringRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SpringService</summary>
    public partial class SpringServiceClient : grpc::ClientBase<SpringServiceClient>
    {
      /// <summary>Creates a new client for SpringService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SpringServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SpringService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SpringServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SpringServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SpringServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Generated.HoroscopResponse getZodiacSign(global::Generated.SpringRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getZodiacSign(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Generated.HoroscopResponse getZodiacSign(global::Generated.SpringRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_getZodiacSign, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Generated.HoroscopResponse> getZodiacSignAsync(global::Generated.SpringRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getZodiacSignAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Generated.HoroscopResponse> getZodiacSignAsync(global::Generated.SpringRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_getZodiacSign, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SpringServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SpringServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SpringServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_getZodiacSign, serviceImpl.getZodiacSign).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SpringServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_getZodiacSign, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Generated.SpringRequest, global::Generated.HoroscopResponse>(serviceImpl.getZodiacSign));
    }

  }
}
#endregion
