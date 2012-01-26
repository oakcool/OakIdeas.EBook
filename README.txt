OakIdeas .NET EBook Library v0.1

+-- Who ------------------------------------
	- Mateus Carvalho http://about.me/oakcool
+-------------------------------------------

+-- The Goal -------------------------------

	Formats:
		EPUB -> http://en.wikipedia.org/wiki/EPub
			Especifications:
				EPUB Publications v3.0
					http://idpf.org/epub/30/spec/epub30-publications.html
				MathML v3.0 (Possible)
					http://www.w3.org/TR/2010/REC-MathML3-20101021/
				Pronunciation Lexicon v1.0 (Possible)
					http://www.w3.org/TR/pronunciation-lexicon/
				Speech Syntheris Markup Language (SSML) v1.0 (Possible)
					http://www.w3.org/TR/speech-synthesis/
			If any of the specifications above are implemented elsewhere, we can use whatever is already there
		Others

	Mapping of the elements on this specigications on an 1 (one) to 1 (one) basis, and overloading the "ToString" in 
	a recusive way, so we can go at a root level and return all the XML under.

	Main functionalities:
		
		- Create From: (Using the specification packaging formats)
			HTML
			PDF
			TXT
			XML

		- Convert To:
			HTML
			PDF
			TXT
			XML		
+-------------------------------------------	

