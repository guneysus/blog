.assembly myassembly {}

.class Foo

{

.method public hidebysig static
void bar()il managed

{

.entrypoint

ldstr "hello world"

call void
[mscorlib]System.Console::WriteLine(class System.String)

ret

}

}