#!/usr/bin/env bash
# Hook simple para evitar commits que contengan patrones obvios de secretos.
# Coloca este script en .git/hooks/pre-commit (chmod +x)
if git diff --cached --name-only | grep -E '\.(cs|ts|js|json|config|env)$' >/dev/null; then
  # buscar patrones básicos
  if git diff --cached | grep -E "API[_-]?KEY|SECRET|PASSWORD|passwd|token|private_key" >/dev/null; then
    echo "ERROR: Se detectaron posibles secretos en el commit. Revísalo antes de commitear."
    exit 1
  fi
fi
exit 0
