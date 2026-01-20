# SECURITY

Pautas de seguridad y manejo de secretos para este repo.

- Nunca commitear secretos (API keys, credenciales). Usa variables de entorno y secretos de GitHub Actions.
- Añadir `.env` a `.gitignore`.
- Habilita Secret Scanning en el repositorio (Settings → Code security and analysis).
- Usa pre-commit hooks para detectar patrones comunes (ej.: `API_KEY=`, `password=`).
- Revisa manualmente cualquier sugerencia de Copilot que incluya URLs, claves o acceso a servicios.
- Reporta vulnerabilidades siguiendo este repo: abre una issue con la etiqueta `security`.
