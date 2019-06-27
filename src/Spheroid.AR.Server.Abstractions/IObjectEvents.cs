﻿/*
 *  Copyright (c) 2019 Spheroid Universe
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */

using Spheroid.Geo;
using System;

namespace Spheroid.AR.Server
{
    public interface IObjectEvents
    {
        void ObjectModel(User user, Guid objectId, AssetSource modelSource, Guid modelId);
        void ObjectClick(User user, Guid objectId);
        void RenderObjects(User user, Bounds bounds);
    }
}
