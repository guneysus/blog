IL := ilasm /nologo /quiet
ILDASM := ildasm

%.dll: %.il
	$(IL) /debug /dll $< /OUT=$@

%.exe: %.il
	$(IL) /debug /OUT=$@ $<
	./$@
	
clean:
	rm *.dll
	rm *.exe
	
play: play.cs
	csc play.cs
	ildasm play.exe

.PHONY: $(ALL) default clean play