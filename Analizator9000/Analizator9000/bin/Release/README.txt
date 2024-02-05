Analizator9000 - README

0. TABLE OF CONTENTS
====================

    1. Introduction
    2. System requirements
    3. Installation
    4. User manual
    5. Source code
    6. Authors
    7. Support and contact information
    8. Changes history
    9. License

1. INTRODUCTION
===============

Analizator9000 is an application which offers a graphical user interface for
statistical analysis of the number of tricks to be taken in a bridge deal
generated upon certain conditions.

The software constitutes an interface for Dealer software and part of BCalc
project: libbcalcDDS library. To find out more on these projects, please refer
to the "AUTHORS" section.

2. SYSTEM REQUIREMENTS
======================

Analizator9000 works within the .NET 3.5 Client Profile environment and as that
it requires a platfrom compatible with the .NET 3.5 framework.

.NET 3.5 system requirements:

    * operating system: Windows XP/Vista/Server 2003/Server 2008/7/8 or newer
     (Windows 7, Windows Server 2008 R2 and Windows 8 or newer
      already provide .NET 3.5 with basic system installation)
    * CPU: equivalence of Pentium 400MHz (minimum); Pentium 1GHz (recommended)
    * memory: 96MB (minimmum); 256MB (recommended)

Application-specific reqirements:

    * display: minumum resolution of 1024x600px; 16-bit colour
    * free disk space: a minimum of 500MB (.NET 3.5) + 5MB (Analizator9000)
    * additional free space: 1MB for full analysis per every thousand deals

WARNING!
    Using this application may require a substantial amount of resources
depending on the size of the commissioned task. Irresponsible runtime parameter
choice for deal generating/analysis may lead to recognizably long execution
time, to the limitation of application responding time or even to the limitation
of user's operating system usage experience. The author recommends a careful
choice of runtime parameters to ensure the recognition of application and system
performance capabilities.

3. INSTALATION
==============

The application is ready to use after unpacking it into a user's disk directory
of choice.

The current version of the application is available from the project's homepage:
    https://github.com/emkael/an9k/releases

After extraction, the software requires the existence of two directorys within
its working directory (provided within the archive):

    * bin/ directory - containing external software used by the analyzer
      (lbcalcdds.dll file from the BCalc project, dealer.exe executable file
       from project Dealer and cygwin1.dll library, required by Dealer)
    * empty files/ directory - necessary for collecting application's output
      files

4. USER MANUAL
==============

The description of usage, along with screenshots and examples, is available from
the project's homepage:
    http://emkael.info/brydz/an9k/manual/

5. SOURCE CODE
==============

Q: In which programming language is Analizator9000 written?
A: C#.

Q: Can I see the source code?
A: Surely!

Q: Where can I acquire it?
A: From the Git repository available at:
    https://github.com/emkael/an9k

Q: What's the environment you've used to create this software?
A: Microsoft Visual Studio/Visual C# 2010 and 2022.

Q: Can I ask you to write feature X into your software?
A: And I tell you, ask, and it will be given to you.

P: I've written feature X into your source code. Can you add it to the your
   release.
O: If it's sensible and I can comprehend its entire codebase without resorting
   to alcoholic beverages stronger than 16-proof (US), I can't see why not.

6. AUTHORS
==========

Analizator9000:
    Micha³ Klichowicz (mkl/emkael)
    WWW: http://emkael.info
    e-mail: emkael@tlen.pl

Dealer:
    Current code maintainer: Henk Uijterwaal
    WWW: http://henku.home.xs4all.nl/html/dealer/authors.html

Bridge Calculator (bcalc):
    Piotr Beling
    WWW: http://bcalc.w8.pl/

Application icon:
    Tonev
    WWW: http://www.iconarchive.com/show/windows-7-icons-by-tonev.html

7. SUPPORT AND CONTACT INFORMATION
==================================

Bug reports, feature suggestions and all other general comments should be
addressed directly to the author, via electrionic means.
The easiest way to communicate with the author is his e-mail inbox:
    emkael@tlen.pl
You can also visit ForumBridge.pl and drop a private message to the user mkl:
    http://www.forumbridge.pl/private.php?do=newpm&u=360
or find an appropriate thread and leave an entry in it.

All reported bugs will be investigated and attempted to fix if only the author
will find some capabilities to do so. It's expected from the user to be able to
provide basic information on how to reproduce the error with a bug report or to
have a sufficient overall computer skills to be able to collect those at the
author's prompt and with his guidance.

The author reserves the right to approach feature requests with any amount of
scepticism the author finds appropriate.

If you find my software useful and would like to thank me for it, write me an
e-mail and let me know you've liked it.
If you'd like to alter it, incorporate into a bigger project or propose a use
for it any other than purely recreational analysis, feel from to do so, just let
me know.
If you need my help with that, let me know, we'll see what we can do.
If you achieved some interesting results or curious conclusions with my
software, feel free to let me know about them.
If you're unsure whether you should write to me in a matter even slightly
related to my software, write me an e-mail. I like e-mails.

If you find my software useful enough to want to thank me in a material way,
you're in a bad luck. I don't take donations, and this software is fully free
and non-commercial. I do like a decent book and a good beer, though.

8. CHANGES HISTORY
==================

2024.02 - 0.13
    * bugfix version: do not analyze contracts that are zeroed in frequency tables

2021.02 - 0.12
    * Chinese translation, courtesy of Li Ruisheng
    * cosmetic fixes to scores/MP/IMP in relation to the declarer
    
2015.12 - 0.11
    * revised GUI
    * i18n/l10n
    * menu toolbar
    * saving boards to PBN
    
2014.12 - 0.10
    * contract analysis tab
    
2013.04 - 0.9.1
    * forcing 32-bit binaries
    
2012.11 - 0.9
    * initial version

9. LICENSE
==========

The 2-clause BSD License

Copyright (c) 2012-2024, Micha³ Klichowicz
All right reserved

Redistribution and use in source and binary forms, with or without modification,
are permitted provided that the following conditions are met:

    * Redistributions of source code must retain the above copyright notice,
      this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright notice,
      this list of conditions and the following disclaimer in the documentation
      and/or other materials provided with the distribution.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON
ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

===

Who needs patience anymore, when all our pleasure's virtual?