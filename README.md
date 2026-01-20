# copilot-cert-practice

Proyecto de práctica para la certificación GitHub Copilot.

Objetivos:
- Practicar uso de GitHub Copilot con C# (.NET 8) y Angular (última estable).
- Implementar y testear funciones con asistencia de Copilot.
- Practicar buenas prácticas de seguridad (secret scanning, pre-commit hooks).
- Configurar CI (GitHub Actions) que ejecute tests .NET y Angular.

Estructura sugerida:
- backend/EmailValidator            -> librería C# (.NET 8) con lógica y tests
- frontend/                         -> app Angular (creada con `ng new`)
- .github/workflows/ci.yml          -> workflow CI para tests
- SECURITY.md                       -> políticas básicas de seguridad
- .gitignore

Cómo empezar (pasos resumidos):
1. Clona/crea el repo en tu cuenta GitHub.
2. Backend:
   - cd backend
   - dotnet new classlib -n EmailValidator -f net8.0
   - dotnet new xunit -n EmailValidator.Tests -f net8.0
   - Añade los archivos proporcionados y referencia el proyecto en el test project.
   - dotnet test
3. Frontend:
   - ng new frontend --routing=false --style=css
   - Añade el componente `email-validator` provisto en `src/app`.
   - npm test (o ng test)
4. Configura husky/pre-commit (opcional) y añade los hooks provistos.
5. Sube a GitHub y abre un PR desde `practice` a `main` cuando tengas la primera entrega (README + implementación + tests).

Primer ejercicio (Semana 1):
- Implementar la clase `EmailValidator` en C#.
- Escribir tests unitarios que cubran: emails válidos, inválidos, casos límite.
- Documentar en README: 2 problemas detectados en sugerencias de Copilot y cómo los corregiste.
- Crear un componente Angular simple que reciba un email y muestre si es válido usando la lógica del backend (puede ser mock local).

Si quieres, puedo darte comandos específicos para cada paso o un script de inicialización.
