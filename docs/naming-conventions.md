# General Naming Conventions
> Recomendations extracted from [Microsoft General Naming Conventions](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions?redirectedfrom=MSDN).

This section describes general naming conventions that relate to word choice, guidelines on using abbreviations and acronyms, and recommendations on how to avoid using language-specific names.

## Word Choice
✅ DO choose easily readable identifier names.

For example, a property named HorizontalAlignment is more English-readable than AlignmentHorizontal.

✅ DO favor readability over brevity.

The property name CanScrollHorizontally is better than ScrollableX (an obscure reference to the X-axis).

❌ DO NOT use underscores, hyphens, or any other nonalphanumeric characters.

❌ DO NOT use Hungarian notation.

❌ AVOID using identifiers that conflict with keywords of widely used programming languages.

According to Rule 4 of the Common Language Specification (CLS), all compliant languages must provide a mechanism that allows access to named items that use a keyword of that language as an identifier. C#, for example, uses the @ sign as an escape mechanism in this case. However, it is still a good idea to avoid common keywords because it is much more difficult to use a method with the escape sequence than one without it.

## Using Abbreviations and Acronyms
❌ DO NOT use abbreviations or contractions as part of identifier names.

For example, use GetWindow rather than GetWin.

❌ DO NOT use any acronyms that are not widely accepted, and even if they are, only when necessary.

## Avoiding Language-Specific Names
✅ DO use semantically interesting names rather than language-specific keywords for type names.

For example, GetLength is a better name than GetInt.

✅ DO use a generic CLR type name, rather than a language-specific name, in the rare cases when an identifier has no semantic meaning beyond its type.

For example, a method converting to Int64 should be named ToInt64, not ToLong (because Int64 is a CLR name for the C#-specific alias long). The following table presents several base data types using the CLR type names (as well as the corresponding type names for C#, Visual Basic, and C++).

✅ DO use a common name, such as value or item, rather than repeating the type name, in the rare cases when an identifier has no semantic meaning and the type of the parameter is not important.