import { Component, ChangeDetectionStrategy, inject } from '@angular/core';
import { SoftwareStore } from '../services/software.store';

@Component({
  selector: 'app-software-list',
  standalone: true,
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [],
  template: `
    <p>List of Software Here</p>
    @for(item of store.entities(); track item.id) { @let i = item();
    <div class="card bg-neutral text-neutral-content w-96">
      <div class="card-body items-center text-center">
        <h2 class="card-title">{{ i.title }}</h2>
        <p>{{ i.title }} from {{ i.vendor }}</p>
        @if(i.isOpenSource) {
        <p>This is Open Source Software</p>
        } @else {
        <p>This is commercial (closed-source) software</p>
        }
        <div class="card-actions justify-end">
          <button class="btn btn-primary">Edit</button>
          <button class="btn btn-ghost">Delete</button>
        </div>
      </div>
    </div>
    }
  `,
  styles: ``,
})
export class ListComponent {
  store = inject(SoftwareStore);
}
