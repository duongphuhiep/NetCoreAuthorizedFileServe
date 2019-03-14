// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CC0091:Use static method", Justification = "Hiep: Controller method can't be static", Scope = "Module")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1051:Do not declare visible instance fields", Justification = "Hiep: For the sake of code brievity, otherwise there will be too much junks in a POCO class", Scope = "Module")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1034:Nested types should not be visible", Justification = "Hiep: The type is used only inside the controller but it is a request parameter, so it has to be public", Scope = "Module")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "CC0037:Remove commented code.", Justification = "Hiep: comment has useful information", Scope = "Module")]


