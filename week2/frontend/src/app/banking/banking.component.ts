import {
  Component,
  ChangeDetectionStrategy,
  signal,
  computed,
  inject,
} from '@angular/core';
import { TransactionHistoryComponent } from './components/transaction-history.component';
import { BankingSuccessNotificationComponent } from './components/banking-success-notification.component';
import { BankingTransactionInputComponent } from './components/banking-transaction-input.component';
import { RouterLink, RouterOutlet } from '@angular/router';
import { BankingNavComponent } from './components/banking-nav.component';
import { BankingStore } from '../services/bank.store';

// id, starting balance , type (deposit | withdraw), amount, new balance

@Component({
  selector: 'app-banking',
  standalone: true,
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [
    TransactionHistoryComponent,
    BankingSuccessNotificationComponent,
    BankingTransactionInputComponent,
    RouterOutlet,
    BankingNavComponent,
    RouterLink,
  ],
  template: `
    <app-banking-nav />
    <div>
      <p>Your Balance is {{ store.balance() }}</p>
      @if(store.isGoldAccount()) {

      <app-banking-success-notification
        message="You are a gold account! You'll get a bonus on your next deposit!"
      />

      } @else {
      <p>
        If you deposit {{ store.amountNeededToBeGold() }} more dollars, you will
        be a gold account!
      </p>
      }

      <div class="p-12">
        <a routerLink="deposit" class="m-8 btn btn-lg btn-success"
          >Make a Deposit</a
        >
        <a routerLink="withdrawal" class="m-8 btn btn-lg btn-success"
          >Make a Withdrawal</a
        >
      </div>
      <router-outlet />
    </div>
  `,
  styles: ``,
})
export class BankingComponent {
  store = inject(BankingStore);
}
