.module dd.exe

.subsystem 3 

.corflags 1

.assembly extern mscorlib

{

  // .originator = (03 68 91 16
// D3 A4 AE 33 )                 

 
.hash = (52 44 F8 C9 55 1F 54 3F 97 D7 AB AD E2 DF 1D E0 

           F2 9D 4F BC )                                   

 
.ver 1:0:2204:21

}

.assembly a as "a"

// {

 
// .hash algorithm 0x00008004

 
// .ver 0:0:0:0

// }

.class private auto ansi zzz
extends System.Object

{

.method public hidebysig static
void vijay() il managed

{

.entrypoint

ldstr "hell"

call void
[mscorlib]System.Console::WriteLine(class System.String)

ret

}

.method public hidebysig
specialname rtspecialname instance void .ctor() il managed

{

.maxstack  8

ldstr "hell1"

call void
[mscorlib]System.Console::WriteLine(class System.String)

ldarg.0

call instance void
[mscorlib]System.Object::.ctor()

ret

}

}