# Generated by the gRPC Python protocol compiler plugin. DO NOT EDIT!
"""Client and server classes corresponding to protobuf-defined services."""
import grpc

import base_pb2 as base__pb2


class NetatmoStub(object):
    """
    Service definitions


    """

    def __init__(self, channel):
        """Constructor.

        Args:
            channel: A grpc.Channel.
        """
        self.GetData = channel.unary_unary(
                '/grpc_base.Netatmo/GetData',
                request_serializer=base__pb2.NetatmoMessages.NetatmoRequest.SerializeToString,
                response_deserializer=base__pb2.NetatmoMessages.NetatmoData.FromString,
                )


class NetatmoServicer(object):
    """
    Service definitions


    """

    def GetData(self, request, context):
        """Missing associated documentation comment in .proto file."""
        context.set_code(grpc.StatusCode.UNIMPLEMENTED)
        context.set_details('Method not implemented!')
        raise NotImplementedError('Method not implemented!')


def add_NetatmoServicer_to_server(servicer, server):
    rpc_method_handlers = {
            'GetData': grpc.unary_unary_rpc_method_handler(
                    servicer.GetData,
                    request_deserializer=base__pb2.NetatmoMessages.NetatmoRequest.FromString,
                    response_serializer=base__pb2.NetatmoMessages.NetatmoData.SerializeToString,
            ),
    }
    generic_handler = grpc.method_handlers_generic_handler(
            'grpc_base.Netatmo', rpc_method_handlers)
    server.add_generic_rpc_handlers((generic_handler,))


 # This class is part of an EXPERIMENTAL API.
class Netatmo(object):
    """
    Service definitions


    """

    @staticmethod
    def GetData(request,
            target,
            options=(),
            channel_credentials=None,
            call_credentials=None,
            insecure=False,
            compression=None,
            wait_for_ready=None,
            timeout=None,
            metadata=None):
        return grpc.experimental.unary_unary(request, target, '/grpc_base.Netatmo/GetData',
            base__pb2.NetatmoMessages.NetatmoRequest.SerializeToString,
            base__pb2.NetatmoMessages.NetatmoData.FromString,
            options, channel_credentials,
            insecure, call_credentials, compression, wait_for_ready, timeout, metadata)


class ImageStub(object):
    """Missing associated documentation comment in .proto file."""

    def __init__(self, channel):
        """Constructor.

        Args:
            channel: A grpc.Channel.
        """
        self.GetImage = channel.unary_unary(
                '/grpc_base.Image/GetImage',
                request_serializer=base__pb2.ImageMessages.ImageRequest.SerializeToString,
                response_deserializer=base__pb2.ImageMessages.ImageData.FromString,
                )


class ImageServicer(object):
    """Missing associated documentation comment in .proto file."""

    def GetImage(self, request, context):
        """Missing associated documentation comment in .proto file."""
        context.set_code(grpc.StatusCode.UNIMPLEMENTED)
        context.set_details('Method not implemented!')
        raise NotImplementedError('Method not implemented!')


def add_ImageServicer_to_server(servicer, server):
    rpc_method_handlers = {
            'GetImage': grpc.unary_unary_rpc_method_handler(
                    servicer.GetImage,
                    request_deserializer=base__pb2.ImageMessages.ImageRequest.FromString,
                    response_serializer=base__pb2.ImageMessages.ImageData.SerializeToString,
            ),
    }
    generic_handler = grpc.method_handlers_generic_handler(
            'grpc_base.Image', rpc_method_handlers)
    server.add_generic_rpc_handlers((generic_handler,))


 # This class is part of an EXPERIMENTAL API.
class Image(object):
    """Missing associated documentation comment in .proto file."""

    @staticmethod
    def GetImage(request,
            target,
            options=(),
            channel_credentials=None,
            call_credentials=None,
            insecure=False,
            compression=None,
            wait_for_ready=None,
            timeout=None,
            metadata=None):
        return grpc.experimental.unary_unary(request, target, '/grpc_base.Image/GetImage',
            base__pb2.ImageMessages.ImageRequest.SerializeToString,
            base__pb2.ImageMessages.ImageData.FromString,
            options, channel_credentials,
            insecure, call_credentials, compression, wait_for_ready, timeout, metadata)


class DisruptiveStub(object):
    """Missing associated documentation comment in .proto file."""

    def __init__(self, channel):
        """Constructor.

        Args:
            channel: A grpc.Channel.
        """
        self.GetTemperatureStream = channel.stream_stream(
                '/grpc_base.Disruptive/GetTemperatureStream',
                request_serializer=base__pb2.DisruptiveMessages.Request.SerializeToString,
                response_deserializer=base__pb2.DisruptiveMessages.Response.FromString,
                )


class DisruptiveServicer(object):
    """Missing associated documentation comment in .proto file."""

    def GetTemperatureStream(self, request_iterator, context):
        """Missing associated documentation comment in .proto file."""
        context.set_code(grpc.StatusCode.UNIMPLEMENTED)
        context.set_details('Method not implemented!')
        raise NotImplementedError('Method not implemented!')


def add_DisruptiveServicer_to_server(servicer, server):
    rpc_method_handlers = {
            'GetTemperatureStream': grpc.stream_stream_rpc_method_handler(
                    servicer.GetTemperatureStream,
                    request_deserializer=base__pb2.DisruptiveMessages.Request.FromString,
                    response_serializer=base__pb2.DisruptiveMessages.Response.SerializeToString,
            ),
    }
    generic_handler = grpc.method_handlers_generic_handler(
            'grpc_base.Disruptive', rpc_method_handlers)
    server.add_generic_rpc_handlers((generic_handler,))


 # This class is part of an EXPERIMENTAL API.
class Disruptive(object):
    """Missing associated documentation comment in .proto file."""

    @staticmethod
    def GetTemperatureStream(request_iterator,
            target,
            options=(),
            channel_credentials=None,
            call_credentials=None,
            insecure=False,
            compression=None,
            wait_for_ready=None,
            timeout=None,
            metadata=None):
        return grpc.experimental.stream_stream(request_iterator, target, '/grpc_base.Disruptive/GetTemperatureStream',
            base__pb2.DisruptiveMessages.Request.SerializeToString,
            base__pb2.DisruptiveMessages.Response.FromString,
            options, channel_credentials,
            insecure, call_credentials, compression, wait_for_ready, timeout, metadata)
