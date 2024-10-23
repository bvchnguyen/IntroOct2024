import { patchState, signalStore, withMethods, withState } from '@ngrx/signals';
import { addEntity, withEntities } from '@ngrx/signals/entities';
import { SoftwareItemCreateModel, SoftwareItemModel } from '../types';
import { inject } from '@angular/core';
import { rxMethod } from '@ngrx/signals/rxjs-interop';
import { mergeMap, pipe } from 'rxjs';
import { tapResponse } from '@ngrx/operators';
import { SoftwareDataService } from './software.data.service';

export const SoftwareStore = signalStore(
  withState({}),
  withEntities<SoftwareItemModel>(),
  withMethods((store) => {
    const service = inject(SoftwareDataService);
    return {
      addItem: rxMethod<SoftwareItemCreateModel>(
        pipe(
          mergeMap((item) =>
            service.addItem(item).pipe(
              tapResponse({
                next: (i) => patchState(store, addEntity(i)),
                error: (e) => console.log(e),
              })
            )
          )
        )
      ),
    };
  })
);
