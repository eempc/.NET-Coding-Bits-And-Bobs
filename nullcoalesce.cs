if (something == null) {
  something = whatever;
}

// Or

if (something == null) something = whatever;

// if null assign whatever

something ??= whatever;

// Slight difference with this ??

something ?? CanDoThisMethod();
