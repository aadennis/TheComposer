using System;
using System.Collections.ObjectModel;

namespace Composer.ViewModel {
    public class ComposerVm {
        public ObservableCollection<Model.Composer> Composers { get; private set; }

        public ComposerVm() {
            Composers = new ObservableCollection<Model.Composer> {
                new Model.Composer{FirstName = "Wolfgang", LastName = "Mozart",
                    DateOfBirth = new DateTime(1701,12,1), IsAlive = false, ShoeSize = 42 },
                new Model.Composer{FirstName = "Ludwig", LastName = "Beethoven",
                    DateOfBirth = new DateTime(1792,12,1), IsAlive = false, ShoeSize = 40 },
                new Model.Composer{FirstName = "Elton", LastName = "John",
                    DateOfBirth = new DateTime(1954,6,29), IsAlive = true, ShoeSize = 28 }
            };
        }
    }
}
