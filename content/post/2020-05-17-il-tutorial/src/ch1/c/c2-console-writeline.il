.assembly myassembly {}

.method void foo() 

{

.entrypoint


ldstr "hello world :)"

call void
[mscorlib]System.Console::WriteLine(class System.String)

ret

}