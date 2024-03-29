type City = {
  name: string;
  population: number;
  treasury: number;
  taxRate: number;
  collectTaxes: () => void;
  applyGrowth: (percentage: number) => void;
  applyRecession: (percentage: number) => void;
};
