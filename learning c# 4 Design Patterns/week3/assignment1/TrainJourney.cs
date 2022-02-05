using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public class TrainJourney : ITrainJourney
    {
        public TrainStation currentStation;
        public int count;
        protected List<TrainStation> trainStations;
        public List<ITrainDisplay> displays;
        public TrainJourney()
        {
            displays = new List<ITrainDisplay>();
            trainStations = new List<TrainStation>();
            trainStations.Add(new TrainStation("Station Den Helder","Spoor 3","12.55","13.03"));
            trainStations.Add(new TrainStation("Den Helder Zuid", "Spoort 1", "13.08", "13.08"));
            trainStations.Add(new TrainStation("Anna Pauloawna", "Spoor 1", "13.14", "13.15"));
            trainStations.Add(new TrainStation("Schagen", "Spoor 1", "13.22", "13.22"));
            trainStations.Add(new TrainStation("Heerhugowaard", "Spoor 1", "13.31", "13.31"));
            trainStations.Add(new TrainStation("Alkmaar Noord", "Spoor 1", "13.37", "13.37"));
            trainStations.Add(new TrainStation("Alkmaar", "Spoor 5", "13.41", "13.44"));
            trainStations.Add(new TrainStation("Heilo", "Spoor 2", "13.49", "13.49"));
            trainStations.Add(new TrainStation("Castricum", "Spoor 2", "13.55", "13.55"));
            trainStations.Add(new TrainStation("Zaandam", "Spoor 4", "14.09", "14.09"));
            trainStations.Add(new TrainStation("Amsterdam Sloterdijk", "Spoor 5", "14.15", "14.15"));
            trainStations.Add(new TrainStation("Amsterdam Centraal", "Spoor 5b", "14.21", "14.24"));
            count = 0;
        }

        public void AddObserver(ITrainDisplay observer)
        {
            displays.Add(observer);
        }

        public void Next_Train()
        {
            currentStation = trainStations[count];
            foreach (ITrainDisplay d in displays)
            {
                d.GetUpdate(currentStation);
            }

            if (count + 1 < trainStations.Count)
            {
                count++;
            }
            else
            {
                count = 0;
            }
        }

        public void RemoveObserver(ITrainDisplay observer)
        {
            displays.Remove(observer);
        }
    }
}
