.assembly myassembly {}

.method void foo() 

{

.entrypoint

call void
[mscorlib]System.Console::WriteLine(class System.String)

ret

}