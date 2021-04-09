.assembly myassembly {}

.method public hidebysig static
void foo()il managed

{

.entrypoint

ldstr "hello world :)"

call void
[mscorlib]System.Console::WriteLine(class System.String)

ret

}