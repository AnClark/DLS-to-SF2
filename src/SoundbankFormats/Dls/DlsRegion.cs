﻿using System.Collections.Generic;

namespace jnm2.SoundbankFormats.Dls
{
    public struct DlsRegion
    {
        public ushort RangeKeyHigh { get; }
        public ushort RangeKeyLow { get; }
        public ushort RangeVelocityHigh { get; }
        public ushort RangeVelocityLow { get; }
        public bool SelfNonExclusive { get; }
        public ushort KeyGroup { get; }
        public DlsWaveSample? WaveSample { get; }
        public DlsWaveLink WaveLink { get; }
        public IReadOnlyList<DlsArticulator> ArticulatorList { get; set; }

        public DlsRegion(ushort rangeKeyHigh, ushort rangeKeyLow, ushort rangeVelocityHigh, ushort rangeVelocityLow, bool selfNonExclusive, ushort keyGroup, DlsWaveSample? waveSample, DlsWaveLink waveLink, IReadOnlyList<DlsArticulator> articulatorList)
        {
            RangeKeyHigh = rangeKeyHigh;
            RangeKeyLow = rangeKeyLow;
            RangeVelocityHigh = rangeVelocityHigh;
            RangeVelocityLow = rangeVelocityLow;
            SelfNonExclusive = selfNonExclusive;
            KeyGroup = keyGroup;
            WaveSample = waveSample;
            WaveLink = waveLink;
            ArticulatorList = articulatorList;
        }
    }
}