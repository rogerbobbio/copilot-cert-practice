import { ComponentFixture, TestBed } from '@angular/core/testing';
import { FormsModule } from '@angular/forms';
import { EmailValidatorComponent } from './email-validator.component';

describe('EmailValidatorComponent', () => {
  let component: EmailValidatorComponent;
  let fixture: ComponentFixture<EmailValidatorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EmailValidatorComponent],
      imports: [FormsModule]
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmailValidatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('debe marcar email válido', () => {
    component.email = 'user@example.com';
    component.validate();
    expect(component.result).toBeTrue();
  });

  it('debe marcar email inválido', () => {
    component.email = 'invalid-email';
    component.validate();
    expect(component.result).toBeFalse();
  });
});
