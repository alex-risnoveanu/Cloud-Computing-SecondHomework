// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AutumnService.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Generated {
  public static partial class AutumnService
  {
    static readonly string __ServiceName = "AutumnService";

    static readonly grpc::Marshaller<global::Generated.HoroscopRequest> __Marshaller_HoroscopRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Generated.HoroscopRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Generated.HoroscopResponse> __Marshaller_HoroscopResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Generated.HoroscopResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Generated.HoroscopRequest, global::Generated.HoroscopResponse> __Method_ShowAutumnSeason = new grpc::Method<global::Generated.HoroscopRequest, global::Generated.HoroscopResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ShowAutumnSeason",
        __Marshaller_HoroscopRequest,
        __Marshaller_HoroscopResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Generated.AutumnServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AutumnService</summary>
    [grpc::BindServiceMethod(typeof(AutumnService), "BindService")]
    public abstract partial class AutumnServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Generated.HoroscopResponse> ShowAutumnSeason(global::Generated.HoroscopRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AutumnService</summary>
    public partial class AutumnServiceClient : grpc::ClientBase<AutumnServiceClient>
    {
      /// <summary>Creates a new client for AutumnService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AutumnServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AutumnService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AutumnServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AutumnServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AutumnServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Generated.HoroscopResponse ShowAutumnSeason(global::Generated.HoroscopRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ShowAutumnSeason(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Generated.HoroscopResponse ShowAutumnSeason(global::Generated.HoroscopRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ShowAutumnSeason, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Generated.HoroscopResponse> ShowAutumnSeasonAsync(global::Generated.HoroscopRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ShowAutumnSeasonAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Generated.HoroscopResponse> ShowAutumnSeasonAsync(global::Generated.HoroscopRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ShowAutumnSeason, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AutumnServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AutumnServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AutumnServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ShowAutumnSeason, serviceImpl.ShowAutumnSeason).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AutumnServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ShowAutumnSeason, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Generated.HoroscopRequest, global::Generated.HoroscopResponse>(serviceImpl.ShowAutumnSeason));
    }

  }
}
#endregion