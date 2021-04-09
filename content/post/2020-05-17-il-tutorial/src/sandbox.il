.assembly extern mscorlib {}
.assembly 'App' {}

.class Program  {
  .method private hidebysig static void Main ()  {
    .entrypoint
    .maxstack 10
    
.locals (int32 V_0, int32 V_1, int32 V_2)    

ldc.i4.1    
stloc.0     
ldc.i4.s    64 
stloc.1     
ldloc.0     
ldloc.1     
add         
stloc.2     
ldloc.2   

ldloc.s V_2

// box [mscorlib]System.Int32 call void [mscorlib]System.Console::WriteLine(class System.Object)
call void [mscorlib]System.Console::WriteLine(int32)

pop
// pop

ldc.i4.s   65

call void [mscorlib]System.Console::WriteLine(wchar)

    ret
  }
} 

