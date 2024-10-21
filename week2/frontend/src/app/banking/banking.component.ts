import {
  Component,
  ChangeDetectionStrategy,
  signal,
  computed,
} from '@angular/core';
import { TransactionRecord } from './types';
import { TransactionHistoryComponent } from './components/transaction-history.component';
import { BankingSuccessNotificationComponent } from './components/banking-success-notification.component';
import { BankingTransactionInputComponent } from './components/banking-transaction-input.component';

@Component({
  selector: 'app-banking',
  standalone: true,
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [
    TransactionHistoryComponent,
    BankingSuccessNotificationComponent,
    BankingTransactionInputComponent,
  ],
  template: `
    <div>
      <p>Your Balance is {{ balance() }}</p>
      @if(isGoldAccount()){
      <app-banking-success-notification message="You are a gold account!" />

      } @else {
      <p>
        If you deposit {{ goldAccountDifference() }} more dollars, you will be a
        gold account
      </p>
      }
      <div>
        <app-banking-transaction-input
          label="deposit"
          (transaction)="deposit($event)"
        />
      </div>
      <app-transaction-history [historyToDisplay]="history()" />
    </div>
  `,
  styles: ``,
})
export class BankingComponent {
  balance = signal(0);
  goldAccountCutOff = signal(5000);

  history = signal<TransactionRecord[]>([]);

  isGoldAccount = computed(() => this.balance() >= this.goldAccountCutOff());

  goldAccountDifference = computed(
    () => this.goldAccountCutOff() - this.balance()
  );

  deposit(amount: number) {
    const newTransaction: TransactionRecord = {
      id: crypto.randomUUID(),
      amount: amount,
      startingBalance: this.balance(),
      newBalance: this.balance() + amount,
      type: 'deposit',
    };
    this.history.set([newTransaction, ...this.history()]);
    this.balance.update((b) => b + amount);
  }

  withdraw(amount: number) {
    const newTransaction: TransactionRecord = {
      id: crypto.randomUUID(),
      amount: amount,
      startingBalance: this.balance(),
      newBalance: this.balance() - amount,
      type: 'withdrawal',
    };
    this.history.set([newTransaction, ...this.history()]);

    this.balance.update((b) => b - amount);
  }
}
