import { Component } from '@angular/core';

@Component({
  selector: 'app-email-validator',
  template: `
    <div>
      <input [(ngModel)]="email" placeholder="Introduce email" />
      <button (click)="validate()">Validar</button>
      <div *ngIf="result !== null">
        <strong>{{ result ? 'VÁLIDO' : 'INVÁLIDO' }}</strong>
      </div>
    </div>
  `
})
export class EmailValidatorComponent {
  email = '';
  result: boolean | null = null;

  validate() {
    // Validación simple en frontend (mismo patrón que backend). En ejercicio ideal: llamar backend.
    const re = /^[^@\s]+@[^@\s]+\.[^@\s]+$/i;
    this.result = !!this.email && re.test(this.email.trim());
  }
}
