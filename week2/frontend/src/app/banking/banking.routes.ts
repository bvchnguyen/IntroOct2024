import { Routes } from '@angular/router';
import { BankingComponent } from './banking.component';
import { BankingStore } from '../services/bank.store';
import { StatementComponent } from './statement.component';

export const BANKING_ROUTES: Routes = [
  {
    path: '',
    component: BankingComponent,
    providers: [BankingStore],
    children: [
      {
        path: 'statement',
        component: StatementComponent,
      },
    ],
  },
];
