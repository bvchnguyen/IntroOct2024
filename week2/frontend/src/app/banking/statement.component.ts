import { Component, ChangeDetectionStrategy, inject } from '@angular/core';
import { BankingStore } from '../services/bank.store';
import { TransactionHistoryComponent } from './components/transaction-history.component';

@Component({
  selector: 'app-banking-statement',
  standalone: true,
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [TransactionHistoryComponent],
  template: `
    <h1 class="text-2xl font-black">Your Statement</h1>
    <app-banking-transaction-history [historyToDisplay]="store.entities()" />
  `,
  styles: ``,
})
export class StatementComponent {
  store = inject(BankingStore);
}
