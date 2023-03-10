# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: base.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()




DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\nbase.proto\x12\tgrpc_base\"\xbb\x02\n\x0fNetatmoMessages\x1a\x10\n\x0eNetatmoRequest\x1a}\n\x0bNetatmoData\x12\x35\n\x06indoor\x18\x01 \x01(\x0b\x32%.grpc_base.NetatmoMessages.IndoorData\x12\x37\n\x07outdoor\x18\x02 \x01(\x0b\x32&.grpc_base.NetatmoMessages.OutdoorData\x1a\x61\n\nIndoorData\x12\x13\n\x0btemperature\x18\x01 \x01(\x02\x12\x0b\n\x03\x43O2\x18\x02 \x01(\x02\x12\x10\n\x08humidity\x18\x03 \x01(\x02\x12\r\n\x05noise\x18\x04 \x01(\x02\x12\x10\n\x08pressure\x18\x05 \x01(\x02\x1a\x34\n\x0bOutdoorData\x12\x13\n\x0btemperature\x18\x01 \x01(\x02\x12\x10\n\x08humidity\x18\x02 \x01(\x02\"\x9b\x01\n\rImageMessages\x1a@\n\x0cImageRequest\x12\x11\n\timagePath\x18\x01 \x01(\t\x12\r\n\x05width\x18\x02 \x01(\x05\x12\x0e\n\x06height\x18\x03 \x01(\x05\x1aH\n\tImageData\x12\x0c\n\x04\x64\x61ta\x18\x01 \x01(\x0c\x12\x0e\n\x06\x66ormat\x18\x02 \x01(\t\x12\r\n\x05width\x18\x03 \x01(\x05\x12\x0e\n\x06height\x18\x04 \x01(\x05\x32i\n\x07Netatmo\x12^\n\x07GetData\x12).grpc_base.NetatmoMessages.NetatmoRequest\x1a&.grpc_base.NetatmoMessages.NetatmoData\"\x00\x32`\n\x05Image\x12W\n\x08GetImage\x12%.grpc_base.ImageMessages.ImageRequest\x1a\".grpc_base.ImageMessages.ImageData\"\x00\x62\x06proto3')

_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, globals())
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'base_pb2', globals())
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _NETATMOMESSAGES._serialized_start=26
  _NETATMOMESSAGES._serialized_end=341
  _NETATMOMESSAGES_NETATMOREQUEST._serialized_start=45
  _NETATMOMESSAGES_NETATMOREQUEST._serialized_end=61
  _NETATMOMESSAGES_NETATMODATA._serialized_start=63
  _NETATMOMESSAGES_NETATMODATA._serialized_end=188
  _NETATMOMESSAGES_INDOORDATA._serialized_start=190
  _NETATMOMESSAGES_INDOORDATA._serialized_end=287
  _NETATMOMESSAGES_OUTDOORDATA._serialized_start=289
  _NETATMOMESSAGES_OUTDOORDATA._serialized_end=341
  _IMAGEMESSAGES._serialized_start=344
  _IMAGEMESSAGES._serialized_end=499
  _IMAGEMESSAGES_IMAGEREQUEST._serialized_start=361
  _IMAGEMESSAGES_IMAGEREQUEST._serialized_end=425
  _IMAGEMESSAGES_IMAGEDATA._serialized_start=427
  _IMAGEMESSAGES_IMAGEDATA._serialized_end=499
  _NETATMO._serialized_start=501
  _NETATMO._serialized_end=606
  _IMAGE._serialized_start=608
  _IMAGE._serialized_end=704
# @@protoc_insertion_point(module_scope)
