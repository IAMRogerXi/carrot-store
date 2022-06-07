﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClusterContract;

namespace ClusterContract
{
    public interface ILeaderElectionService
    {
        public void StartElection();

        public void SendElectionNotification(ICluster cluster);

        public void Vote();

        public void ProcessVoteResult();

        public void CompleteElection();
    }
}