import { TestBed } from '@angular/core/testing';
import { ResolveFn } from '@angular/router';

import { testResolver } from './test.resolver';

describe('testResolver', () => {
  const executeResolver: ResolveFn<boolean> = (...resolverParameters) => 
      TestBed.runInInjectionContext(() => testResolver(...resolverParameters));

  beforeEach(() => {
    TestBed.configureTestingModule({});
  });

  it('should be created', () => {
    expect(executeResolver).toBeTruthy();
  });
});
