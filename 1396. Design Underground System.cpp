class UndergroundSystem {
public:
    unordered_map<string, vector<int>> Map;
    unordered_map<int, pair<string, int>> Map2;
    UndergroundSystem() {

    }

    void checkIn(int id, string stationName, int t) {
        Map2[id] = { stationName, t };
    }

    void checkOut(int id, string stationName, int t) {
        Map[Map2[id].first + "to" + stationName].push_back(t - Map2[id].second);
    }

    double getAverageTime(string startStation, string endStation) {
        double Max = 0;
        vector<int> temp = Map[startStation + "to" + endStation];
        for (auto n : temp) Max += n;
        return Max / temp.size();
    }
};

/**
 * Your UndergroundSystem object will be instantiated and called as such:
 * UndergroundSystem* obj = new UndergroundSystem();
 * obj->checkIn(id,stationName,t);
 * obj->checkOut(id,stationName,t);
 * double param_3 = obj->getAverageTime(startStation,endStation);
 */