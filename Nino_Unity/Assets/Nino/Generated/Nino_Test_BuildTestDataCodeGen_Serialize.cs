/* this is generated by nino */
namespace Nino.Test
{
    public partial class BuildTestDataCodeGen
    {
        public static BuildTestDataCodeGen.SerializationHelper NinoSerializationHelper = new BuildTestDataCodeGen.SerializationHelper();
        public class SerializationHelper: Nino.Serialization.ISerializationHelper<BuildTestDataCodeGen>
        {
            #region NINO_CODEGEN
            public void NinoWriteMembers(BuildTestDataCodeGen value, Nino.Serialization.Writer writer)
            {
                writer.Write(value.a);
                writer.Write(value.b);
                writer.Write(value.c);
                writer.Write(value.d);
                writer.CompressAndWrite(value.e);
                writer.CompressAndWrite(value.f);
                writer.CompressAndWrite(value.g);
                writer.CompressAndWrite(value.h);
                writer.Write(value.i);
                writer.Write(value.j);
                writer.Write(value.k);
                writer.Write(value.l);
                writer.Write(value.m);
                writer.Write(value.n);
                if(value.o != null)
                {
                    writer.CompressAndWrite(value.o.Count);
                    foreach (var entry in value.o)
                    {
                        writer.CompressAndWrite(entry);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.p != null)
                {
                    writer.CompressAndWrite(value.p.Count);
                    foreach (var entry in value.p)
                    {
                        Nino.Test.NotIncludeAllClass.NinoSerializationHelper.NinoWriteMembers(entry, writer);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.q != null)
                {
                    writer.CompressAndWrite(value.q.Length);
                    foreach (var entry in value.q)
                    {
                        writer.Write(entry);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.r != null)
                {
                    writer.CompressAndWrite(value.r.Length);
                    foreach (var entry in value.r)
                    {
                        Nino.Test.NotIncludeAllClass.NinoSerializationHelper.NinoWriteMembers(entry, writer);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.s != null)
                {
                    writer.CompressAndWrite(value.s.Count);
                    foreach (var entry in value.s)
                    {
                        writer.Write(entry.Key);
                        Nino.Test.NotIncludeAllClass.NinoSerializationHelper.NinoWriteMembers(entry.Value, writer);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.t != null)
                {
                    writer.CompressAndWrite(value.t.Count);
                    foreach (var entry in value.t)
                    {
                        Nino.Test.NotIncludeAllClass.NinoSerializationHelper.NinoWriteMembers(entry.Key, writer);
                        writer.CompressAndWrite(entry.Value);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.u != null)
                {
                    writer.CompressAndWrite(value.u.Count);
                    foreach (var entry in value.u)
                    {
                        writer.Write(entry.Key);
                        writer.CompressAndWrite(entry.Value);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.v != null)
                {
                    writer.CompressAndWrite(value.v.Count);
                    foreach (var entry in value.v)
                    {
                        Nino.Test.NotIncludeAllClass.NinoSerializationHelper.NinoWriteMembers(entry.Key, writer);
                        Nino.Test.NotIncludeAllClass.NinoSerializationHelper.NinoWriteMembers(entry.Value, writer);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
            }

            public BuildTestDataCodeGen NinoReadMembers(Nino.Serialization.Reader reader)
            {
                BuildTestDataCodeGen value = new BuildTestDataCodeGen();
                value.a = reader.ReadByte();
                value.b = reader.ReadSByte();
                value.c = reader.ReadInt16();
                value.d = reader.ReadUInt16();
                value.e =  (System.Int32)reader.DecompressAndReadNumber();
                value.f =  (System.UInt32)reader.DecompressAndReadNumber();
                value.g =  (System.Int64)reader.DecompressAndReadNumber();
                value.h =  (System.UInt64)reader.DecompressAndReadNumber();
                value.i = reader.ReadSingle();
                value.j = reader.ReadDouble();
                value.k = reader.ReadDecimal();
                value.l = reader.ReadBool();
                value.m = reader.ReadChar();
                value.n = reader.ReadString();
                value.o = new System.Collections.Generic.List<System.Int32>(reader.ReadLength());
                for(int i = 0, cnt = value.o.Capacity; i < cnt; i++)
                {
                    value.o.Add( (System.Int32)reader.DecompressAndReadNumber());
                }
                value.p = new System.Collections.Generic.List<Nino.Test.NotIncludeAllClass>(reader.ReadLength());
                for(int i = 0, cnt = value.p.Capacity; i < cnt; i++)
                {
                    value.p.Add(Nino.Test.NotIncludeAllClass.NinoSerializationHelper.NinoReadMembers(reader));
                }
                value.q = reader.ReadBytes(reader.ReadLength());
                value.r = new Nino.Test.NotIncludeAllClass[reader.ReadLength()];
                for(int i = 0, cnt = value.r.Length; i < cnt; i++)
                {
                    value.r[i] = Nino.Test.NotIncludeAllClass.NinoSerializationHelper.NinoReadMembers(reader);
                }
                var this_s_len = reader.ReadLength();
                value.s = new System.Collections.Generic.Dictionary<System.String,Nino.Test.NotIncludeAllClass>(this_s_len);
                for(int i = 0; i < this_s_len; i++)
                {
                    value.s[reader.ReadString()] = Nino.Test.NotIncludeAllClass.NinoSerializationHelper.NinoReadMembers(reader);
                }
                var this_t_len = reader.ReadLength();
                value.t = new System.Collections.Generic.Dictionary<Nino.Test.NotIncludeAllClass,System.Int32>(this_t_len);
                for(int i = 0; i < this_t_len; i++)
                {
                    value.t[Nino.Test.NotIncludeAllClass.NinoSerializationHelper.NinoReadMembers(reader)] =  (System.Int32)reader.DecompressAndReadNumber();
                }
                var this_u_len = reader.ReadLength();
                value.u = new System.Collections.Generic.Dictionary<System.String,System.Int32>(this_u_len);
                for(int i = 0; i < this_u_len; i++)
                {
                    value.u[reader.ReadString()] =  (System.Int32)reader.DecompressAndReadNumber();
                }
                var this_v_len = reader.ReadLength();
                value.v = new System.Collections.Generic.Dictionary<Nino.Test.NotIncludeAllClass,Nino.Test.NotIncludeAllClass>(this_v_len);
                for(int i = 0; i < this_v_len; i++)
                {
                    value.v[Nino.Test.NotIncludeAllClass.NinoSerializationHelper.NinoReadMembers(reader)] = Nino.Test.NotIncludeAllClass.NinoSerializationHelper.NinoReadMembers(reader);
                }
                return value;
            }
            #endregion
        }
    }
}