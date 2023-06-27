What is this tool?

This is a program which automatically helps you out with aim punch, a phenomenon in Elden Ring of which affects colossal greatswords and great thrusting swords the most, though other weapons are affected as well. The phenomenon can be found on YouTube, if you search "Amir Elden Ring Aim Punch". 

If you don't want to sit through an in-depth analysis, it goes like the following:

I swing my weapon -> enemy hits me -> the ExecAddDamage function in the c0000.hks plays an animation, such as ExecEventNoReset("W_AddDamageLv0") -> the animation overlays onto my current animation, but this animation features swinging of the arms, causing my attack to be knocked to the side, turning what would have normally been a hit into a miss, and almost completely at random. This makes fighting smaller enemies in Elden Ring, such as baby octopi and players quite annoying, as trades favor different weapon types, seemingly for no reason other than bad luck.



What does this tool do to alleviate this?

Blubber made some animation tweaks to the default damage overlay files so that the arms are frozen in place during the overlay, meaning they are unaffected and it is only the body that moves. This still conveys the feeling of impact given by the damage overlay without negatively affecing one's swing.



How do I use this tool?

There are two choices. If you are playing a mod that does not feature the c0000_a00_hi.anibnd.dcx then you can just copy and paste the vanilla + aim punch fix file I included in the folder. This is the vanilla c0000_a00_hi.anibnd.dcx which now contains Blubber's anti-aimpunch animations. Works with all mods that do not have a c0000_a00_hi.anibnd.dcx in their chr folder.

If you have a mod that features a changed c0000_a00_hi.anibnd.dcx, start the exe, drag and drop your c0000_a00_hi_anibnd.dcx onto the Console (don't bother trimming the quotation marks) and press ENTER. Then wait for the program to finish and you are done!



Have fun!